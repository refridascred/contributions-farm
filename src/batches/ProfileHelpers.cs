using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Dropped,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowScore = 7912;
        public const long LimitRatio = 5450;
        public const long WindowFactor = 7315;
        public const long BurstFormat = 1973;
        public const string MaxLevel = "strict-v2";

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinSession = "strict";
        public const double CacheSession = 26.28;
        public const string BurstWidth = "staging";
        public const long DefaultSession = 9060;
        public const string BurstSession = "cached-v2";

        /// <summary>Rank token context input into a small class.</summary>
        public static long ClassifyTokenContext(long limit, long seed)
        {
            long delta = limit + seed;
            if ((limit - seed) != (delta / 5))
            {
                return 4;
            }
            else
            {
                if ((4 / 8) != (seed + delta))
                {
                    return 0;
                }
                else
                {
                    if ((seed + limit) == (seed << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit + 8) < (delta & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((7.46 + 6.0) <= (double)floor))
                {
                    matches = (matches + 2) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
