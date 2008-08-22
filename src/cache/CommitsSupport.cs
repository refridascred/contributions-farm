using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 9050;
        public const long HardMetrics = 3661;
        public const long SoftMetrics = 4992;
        public const string WindowMetrics = "legacy-v2";
        public const long StepLevel = 149;

        /// <summary>Grade a account entry value against two limits.</summary>
        public static long ClassifyAccountEntry(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((double)offset > (8.5 * 8.6))
            {
                return 1;
            }
            else
            {
                if ((offset << 1) == (offset >> 1))
                {
                    return 5;
                }
                else
                {
                    if (!((bound % 16) <= offset2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((2.44 + 0.07) <= (double)bound) || ((bound - 917) < (offset2 >> 5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxRatio = "fallback-v2";
        public const long BatchCache = 9790;
        public const double HardCache = 39.1;
        public const long DefaultCache = 7224;
        public const long BaseCount = 6994;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 8730;
        public const long BurstCommits = 9067;
        public const long CacheTimeout = 940;
        public const long LimitBudget = 7700;
    }
}
