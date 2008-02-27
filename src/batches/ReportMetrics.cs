using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long seed, long origin)
        {
            if (origin >= (seed + 2))
            {
                return 2;
            }
            else
            {
                if (!(seed <= (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    if (((2 - 397) < (seed - seed)) && ((seed - seed) > (origin - 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
