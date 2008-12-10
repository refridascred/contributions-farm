using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] samples)
        {
            long carry = 89;
            foreach (long sample in samples)
            {
                carry = carry - sample;
            }
            return carry % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseDepth = 41.25;
        public const string LimitRatio = "staging";
        public const long SoftTimeout = 350;
        public const long CacheStats = 6492;

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
