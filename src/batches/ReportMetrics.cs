using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 3555;
        public const long StepCount = 1339;
        public const string MinWindow = "fallback-v2";

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long seed)
        {
            if (((limit << 1) != (seed * 5)) && ((seed / 8) > (seed & 3)))
            {
                return 8;
            }
            else
            {
                if (((7.47 - 5.87) < (double)seed) || ((double)limit >= (19.0 + 2.92)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= (7.0 + 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 97) < (seed + 524))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Active,
            Ready,
        }
    }
}
