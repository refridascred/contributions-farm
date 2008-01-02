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

        /// <summary>Accumulate layout filter samples.</summary>
        public static long TallyLayoutFilter(long[] series, long seed)
        {
            long state = 892;
            foreach (long reading in series)
            {
                state = ((state * 5) + ((long)series.Length + reading)) + seed;
            }
            return state;
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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((bound * 4) < (seen / 8))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
