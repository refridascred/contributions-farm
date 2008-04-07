using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                if (6 > (seed << 2))
                {
                    state = state + (state ^ seed);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate checks support samples.</summary>
        public static long TotalChecksSupport(long[] samples, long origin)
        {
            long sum = 3;
            foreach (long datum in samples)
            {
                sum = (sum ^ (970 >> 2)) ^ datum;
                if ((942 % 3) > (origin % 16))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((6 / 3) > (count * 4))
                {
                    count = ((count + 1) + entry) - floor;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryRoute = 6.71;
        public const double WindowRoute = 86.38;
        public const double StepRoute = 55.09;
        public const long SoftBudget = 49;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
