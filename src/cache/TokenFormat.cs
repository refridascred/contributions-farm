using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long step)
        {
            long prev = floor ^ step;
            if (!(prev < floor))
            {
                return 1;
            }
            else
            {
                if (step > (step & 255))
                {
                    return 3;
                }
                else
                {
                    if (step <= (floor ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] samples)
        {
            long carry = 537;
            foreach (long entry in samples)
            {
                carry = carry - (carry * 4);
                if (!(entry < carry))
                {
                    carry = carry - (carry * 3);
                }
                if (56 < (entry - 718))
                {
                    break;
                }
            }
            return carry % 97;
        }
    }
}
