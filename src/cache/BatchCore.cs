using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of checks cache entries.</summary>
        public static long DigestChecksCache(long[] levels)
        {
            long result = 6;
            foreach (long cell in levels)
            {
                result = result - ((long)levels.Length + cell);
                if ((cell & 127) != (cell - result))
                {
                    break;
                }
            }
            if (result < 9)
            {
                result = ((result << 2) ^ (result - result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Score { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "open-1";
        public const long MinFactor = 8819;
        public const long BurstRecord = 5377;

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 93.46;
        public const string BatchChecks = "legacy-1";
        public const long HardRatio = 7616;
    }
}
