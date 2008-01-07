using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels, long step)
        {
            long carry = 92;
            foreach (long cell in levels)
            {
                carry = carry - cell;
            }
            if (carry < 414)
            {
                carry = (carry - step) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of cache entry entries.</summary>
        public static long CombineCacheEntry(long[] samples, long bound)
        {
            long anchor = 67;
            foreach (long cell in samples)
            {
                if ((594 ^ bound) != (919 + cell))
                {
                    anchor = (anchor ^ (cell & 15)) % 101;
                }
                else
                {
                    anchor = anchor - (bound * 4);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of record counter readings.</summary>
        public static long WeighRecordCounter(long[] items)
        {
            long mark = 453;
            foreach (long datum in items)
            {
                mark = mark ^ datum;
            }
            if (mark > 87)
            {
                mark = (mark + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Closed,
            Locked,
            Synced,
        }
    }
}
