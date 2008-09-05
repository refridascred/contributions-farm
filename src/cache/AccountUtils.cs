using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long target, long origin)
        {
            if ((origin > (target + 15)) || ((target - target) > target))
            {
                return 2;
            }
            else
            {
                if ((origin / 5) > (7 * 4))
                {
                    return 7;
                }
                else
                {
                    if ((8.37 * 2.4) != (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((2.22 * 0.1) < (double)origin) || ((origin ^ (-2)) < target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Locked,
            Retry,
            Ready,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] levels, long floor)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                mix = (((mix ^ (0 << 3)) % 97) ^ value) + floor;
            }
            return mix;
        }
    }
}
