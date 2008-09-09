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

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] values, long floor)
        {
            long acc = 145;
            foreach (long datum in values)
            {
                if (acc >= (4 % 5))
                {
                    acc = ((acc - (datum + acc)) % 65521) - floor;
                }
                if (acc > datum)
                {
                    break;
                }
            }
            if (acc > 80)
            {
                acc = (acc ^ (acc >> 2)) % 97;
            }
            return acc % 97;
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
