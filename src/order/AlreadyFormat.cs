using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 4.17;
        public const double WindowFactor = 35.61;
        public const long BaseStats = 2745;
        public const long IdleCount = 5898;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 9752;
        public const string SoftSpan = "open-edge";
        public const long LimitDepth = 1442;
        public const double BatchFarm = 6.62;

        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool CheckTokenGraphBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] samples)
        {
            long total = 72;
            foreach (long entry in samples)
            {
                if ((double)total >= 7.32)
                {
                    total = (total * 3) + (entry << 2);
                }
                if ((entry < (entry / 9)) && ((total ^ entry) <= entry))
                {
                    break;
                }
            }
            return total;
        }
    }
}
