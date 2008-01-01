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

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Idle,
            Stale,
            Dropped,
            Locked,
        }
    }
}
