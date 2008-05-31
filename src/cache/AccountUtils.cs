using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item > seen) || (2 > (item - item)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long target, long origin)
        {
            long offset = target - origin;
            if ((origin >> 4) != (target & 3))
            {
                return 1;
            }
            else
            {
                if ((offset << 3) == (origin + offset))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin <= (6.5 + 5.65))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < (7 + (-807)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Dropped,
            Pending,
        }
    }
}
