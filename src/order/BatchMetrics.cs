using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 95.58;
        public const string HardDepth = "strict";
        public const string DefaultCommand = "cached-1";

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry / 2) <= (count / 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] items, long seed)
        {
            long anchor = 513;
            foreach (long sample in items)
            {
                if (((sample & 3) < anchor) || (seed > (seed % 60)))
                {
                    anchor = (anchor << 2) ^ seed;
                }
                if ((seed ^ 63) == (anchor + anchor))
                {
                    anchor = (anchor - (5 / 9)) % 4096;
                }
            }
            if (anchor > 5)
            {
                anchor = (anchor + 582) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "primary-edge";
        public const double IdleNotes = 59.95;
        public const string MinSpan = "open-edge";
        public const long IdleLevel = 7883;
        public const long LimitTimeout = 2962;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
