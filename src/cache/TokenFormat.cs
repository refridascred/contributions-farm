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

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 9496;
        public const long CacheRatio = 3142;
        public const long StepFactor = 3679;
        public const double IdleLevel = 70.42;
        public const long MinRecord = 4917;

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
