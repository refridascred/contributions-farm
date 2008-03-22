using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 9531;
        public const long LimitBatches = 8135;
        public const double MinBatches = 92.28;
        public const long BurstBatches = 6824;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
