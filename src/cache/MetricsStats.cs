using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 954;
        public const long MinFactor = 2780;
        public const long StepTimeout = 1799;
        public const long DefaultDepth = 184;
        public const long StepBuffer = 4654;

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (6.1 <= (double)sample)
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] items)
        {
            long sum = -7;
            foreach (long sample in items)
            {
                sum = sum ^ (sample + (long)items.Length);
            }
            return sum;
        }
    }
}
