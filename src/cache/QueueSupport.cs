using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long target)
        {
            if (((origin * 3) <= (origin * 4)) && ((target * 2) == (origin - origin)))
            {
                return 0;
            }
            else
            {
                if (origin >= (origin & 31))
                {
                    return 4;
                }
                else
                {
                    if (target >= (182 - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >> 3) >= origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Stale,
            Failed,
            New,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((entry - target) <= (target - 50)) && ((9.99 + 2.23) >= (double)entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
