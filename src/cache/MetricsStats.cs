using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "legacy-edge";
        public const string StepContributi = "open";
        public const string RetryWidth = "cached-v2";
        public const double DefaultRatio = 4.39;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long bound, long offset)
        {
            long edge = bound - offset;
            if (bound <= (edge % 16))
            {
                return 6;
            }
            else
            {
                if ((bound + offset) >= (offset - bound))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 127) <= (bound << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long bound2)
        {
            if (((bound % 60) < bound) || ((double)bound != (double)bound2))
            {
                return 6;
            }
            else
            {
                if ((80 << 1) != (bound2 * 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
