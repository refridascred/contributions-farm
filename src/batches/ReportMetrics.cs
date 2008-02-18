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

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }
    }
}
