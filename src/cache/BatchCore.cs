using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 1598;
        public const long LimitProfile = 7191;
        public const long BurstProfile = 513;
        public const long DefaultProfile = 9702;

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples, long offset)
        {
            long state = 816;
            foreach (long item in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 3) + item) ^ (long)i;
                }
                if (!((6 + item) <= (offset + offset)))
                {
                    state = (state << 3) ^ (offset + state);
                    state = (state + item) % 255;
                }
                state = (state - (217 % 7)) % 101;
            }
            return state;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long target)
        {
            if ((target << 3) >= (target / 7))
            {
                return 5;
            }
            else
            {
                if ((bound > (target + 770)) || (bound >= target))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((bound - bound) >= (bound ^ bound)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
