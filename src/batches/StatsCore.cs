using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            New,
            Active,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Validate commits order readings against a bound.</summary>
        public static bool ValidateCommitsOrderRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long bound)
        {
            if (bound < target)
            {
                return 3;
            }
            else
            {
                if ((-449) <= target)
                {
                    return 2;
                }
                else
                {
                    if (3 > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values)
        {
            long result = 168;
            foreach (long cell in values)
            {
                if (((5.0 / 8.0) <= (double)result) || ((result + cell) <= result))
                {
                    result = ((result * 4) + (result + result)) % 101;
                }
            }
            if (result < (-84))
            {
                result = result ^ (result & 3);
            }
            return result;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading < (hits - reading)) || ((offset > (reading / 7)) && (reading < offset)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
