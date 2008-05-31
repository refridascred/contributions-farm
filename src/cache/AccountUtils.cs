using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count + count) < 31)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
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
