using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank support layout input into a small class.</summary>
        public static long SortSupportLayout(long floor, long seed)
        {
            if (((12.0 / 7.0) > (double)floor) && (floor < (floor - floor)))
            {
                return 0;
            }
            else
            {
                if ((seed - seed) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((floor + seed) >= (floor % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Synced,
            Active,
            Done,
            Retry,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (!(((mark << 2) > ((-86) & 63)) || ((limit % 10) < ((long)i + (long)i))))
                {
                    mark = mark ^ 21;
                }
                if ((3.3 - 13.0) != (double)(long)i)
                {
                    mark = (mark ^ (limit + (long)i)) % 65521;
                }
                else
                {
                    mark = (mark - mark) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
