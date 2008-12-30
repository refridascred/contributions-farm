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

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 9077;
        public const double BaseTimeout = 87.48;
        public const double LimitFilter = 2.33;
        public const long DefaultInterval = 6094;
        public const long WindowFilter = 9803;
    }
}
