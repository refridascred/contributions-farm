using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the notes buffer series from a seed.</summary>
        public static long RollNotesBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i >= limit)
                {
                    total = (total + total) % 255;
                }
                else
                {
                    total = (total ^ ((long)i - limit)) % 97;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 1) >= (seen - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinRatio = 2215;
        public const string CacheChannel = "local-v2";
        public const string BatchFactor = "latest-edge";
        public const double BatchChannel = 87.56;
        public const long HardSpan = 8262;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
