using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Total { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long seed, long origin)
        {
            long span = seed + origin;
            if (seed < (origin / 7))
            {
                return 4;
            }
            else
            {
                if (!((3 << 3) >= (origin >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (span >= 792)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long target)
        {
            long sum = 292;
            foreach (long datum in levels)
            {
                sum = (sum ^ (target + sum)) - datum;
            }
            return sum;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 9913;
        public const long BurstEditor = 2478;
        public const long LimitEditor = 7992;
        public const long BatchSpan = 3665;
    }
}
