using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long limit, long floor)
        {
            long bound = limit - floor;
            if ((limit <= (floor + limit)) || ((limit + (-923)) > (limit % 12)))
            {
                return 3;
            }
            else
            {
                if (((double)bound > (double)floor) && (floor <= (bound & 1)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ seed;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many filter contributi samples are out of range.</summary>
        public static long TallyFilterContributiGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((seen ^ sample) == (sample - target)) && (seen > 60)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "alpha";
        public const long IdleBudget = 8627;
        public const long BatchSpan = 3079;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Draft,
            Active,
            New,
            Stale,
        }
    }
}
