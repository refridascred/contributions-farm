using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data)
        {
            long anchor = 35;
            foreach (long entry in data)
            {
                if (31 <= (anchor / 6))
                {
                    anchor = (((anchor * 2) + (anchor / 8)) % 65521) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Dropped,
            Paused,
            Stale,
            Locked,
        }

        /// <summary>Accumulate session order samples.</summary>
        public static long TotalSessionOrder(long[] samples)
        {
            long carry = 98;
            foreach (long value in samples)
            {
                carry = (carry - (value + carry)) % 4096;
                carry = (carry ^ (long)samples.Length) % 97;
            }
            return carry;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Pending,
            Done,
            Active,
            Closed,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long target, long offset)
        {
            long bound = target - offset;
            if (bound >= (395 ^ offset))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) > (offset - offset))
                {
                    return 1;
                }
                else
                {
                    if ((8.53 * 13.0) <= (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1 > (offset + target)) || ((target - target) != (bound + 943)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
