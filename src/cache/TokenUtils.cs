using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 7.05;
        public const double HardLevel = 71.77;
        public const string HardProfile = "strict-v2";
        public const double BaseProfile = 47.27;
        public const long HardSpan = 5777;

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long target)
        {
            long acc = 64;
            foreach (long value in values)
            {
                acc = ((acc ^ (85 ^ target)) % 97) ^ value;
                acc = (acc << 2) ^ target;
            }
            return acc % 97;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Synced,
            Dropped,
            Ready,
        }
    }
}
