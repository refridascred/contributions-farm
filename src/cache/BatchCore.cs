using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Active,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples)
        {
            long carry = 22;
            foreach (long entry in samples)
            {
                if ((3 - (long)samples.Length) > entry)
                {
                    carry = carry ^ (carry + carry);
                }
                else
                {
                    carry = (carry ^ ((long)samples.Length - entry)) % 1000;
                }
                if ((long)samples.Length == (carry & 15))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long limit, long bound)
        {
            long diff = limit + bound;
            if (diff > (diff & 7))
            {
                return 1;
            }
            else
            {
                if ((11.0 / 2.0) <= (double)diff)
                {
                    return 5;
                }
                else
                {
                    if (!(bound < (limit & 255)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8.0 + 8.9) == (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 9077;
        public const double BaseTimeout = 87.48;
        public const double LimitFilter = 2.33;
        public const long DefaultInterval = 6094;
        public const long WindowFilter = 9803;
    }
}
