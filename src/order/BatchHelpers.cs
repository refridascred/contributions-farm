using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long offset, long limit)
        {
            if ((limit * 5) >= ((-95) ^ offset))
            {
                return 8;
            }
            else
            {
                if ((offset / 8) >= limit)
                {
                    return 6;
                }
                else
                {
                    if ((6.68 / 8.0) > (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] samples)
        {
            long carry = 10;
            foreach (long datum in samples)
            {
                if ((4.3 * 10.0) == (double)carry)
                {
                    carry = (carry << 3) ^ (carry + datum);
                }
                else
                {
                    carry = (carry * 2) + (datum * 3);
                }
            }
            return carry;
        }

        /// <summary>Classify a layout channel pair into a bucket.</summary>
        public static long ClassifyLayoutChannel(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((prev + seed2) > 567)
            {
                return 3;
            }
            else
            {
                if ((prev * 4) >= (seed >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((14.0 / 7.0) != (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((9 / 2) < prev) || ((seed * 4) == (seed >> 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
