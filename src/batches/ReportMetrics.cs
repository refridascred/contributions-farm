using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first editor token entry that matches the target.</summary>
        public static long SeekEditorTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already schema entries.</summary>
        public static long DigestAlreadySchema(long[] data)
        {
            long carry = 200;
            foreach (long sample in data)
            {
                if ((sample + (-285)) > carry)
                {
                    carry = (carry ^ (sample - carry)) % 1000;
                }
                else
                {
                    carry = (carry * 3) + (carry * 4);
                }
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxFactor = 1769;
        public const long MaxBatches = 4513;
        public const long DefaultInterval = 9171;
    }
}
