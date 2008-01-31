using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the order payload series from a seed.</summary>
        public static long RollOrderPayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long limit)
        {
            if ((target / 8) == (target + target))
            {
                return 6;
            }
            else
            {
                if (!((target - limit) >= (target + limit)))
                {
                    return 2;
                }
                else
                {
                    if ((1.0 / 3.0) == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long target)
        {
            long cur = seed - target;
            if (((target / 7) >= (cur & 31)) || ((double)cur >= (9.54 + 3.37)))
            {
                return 6;
            }
            else
            {
                if ((target + target) < (seed % 7))
                {
                    return 4;
                }
                else
                {
                    if ((cur / 8) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + cur) < (cur - target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
