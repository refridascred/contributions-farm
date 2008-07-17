using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinCount = "cached-1";
        public const string WindowReport = "latest-v2";
        public const double MaxLevel = 2.05;
        public const long LimitLevel = 6312;

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long floor)
        {
            if ((4.79 + 14.0) > (double)floor)
            {
                return 6;
            }
            else
            {
                if (floor >= (700 / 3))
                {
                    return 7;
                }
                else
                {
                    if (!((seed ^ seed) < (seed & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-2) - floor) < (seed + seed))
                        {
                            return 4;
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
}
