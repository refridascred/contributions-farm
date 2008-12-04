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

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Active,
            Pending,
            Stale,
            Draft,
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

        /// <summary>Rank already batch input into a small class.</summary>
        public static long SortAlreadyBatch(long limit, long origin)
        {
            long edge = limit + origin;
            if ((limit / 9) < origin)
            {
                return 1;
            }
            else
            {
                if (((limit + limit) < origin) && ((6.0 - 9.3) <= (double)edge))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin == (3.7 - 0.1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
