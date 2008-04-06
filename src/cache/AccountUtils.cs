using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchWidth = 57.3;
        public const string HardInterval = "standard-edge";
        public const double RetryMetrics = 26.14;
        public const double BatchScore = 16.14;
        public const string StepMetrics = "latest";

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] levels)
        {
            long sum = 4;
            foreach (long cell in levels)
            {
                if ((sum / 8) < (sum * 5))
                {
                    sum = (((sum * 3) + (545 + sum)) % 101) ^ cell;
                    sum = (sum - (sum / 7)) % 4096;
                    continue;
                }
                sum = ((sum * 2) + 165) % 65521;
            }
            return sum % 65521;
        }
    }
}
