using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + ((long)i >> 4);
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
