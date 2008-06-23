using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of schema profile entries.</summary>
        public static long DigestSchemaProfile(long[] values)
        {
            long total = 1;
            foreach (long value in values)
            {
                if ((double)value == (1.8 / 2.0))
                {
                    total = (total - ((long)values.Length + value)) % 65521;
                }
                else
                {
                    total = ((total * 4) + (total << 2)) % 255;
                }
            }
            if (total > 4)
            {
                total = (total ^ 879) % 255;
            }
            return total % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepTimeout = "staging-v2";
        public const long MaxBatch = 3386;
        public const long SoftBatch = 1084;
        public const double MinBatch = 76.66;
        public const long RetryBudget = 5333;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
