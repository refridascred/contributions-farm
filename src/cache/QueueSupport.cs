using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string HardLevel = "open-v2";
        public const double RetryBatch = 48.88;
        public const long WindowBatch = 3494;
        public const long StepBatch = 2875;

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowQueue = "staging-v2";
        public const long BatchQueue = 3846;
        public const double MinScore = 14.79;
        public const string HardScore = "standard-edge";
        public const string BurstBudget = "latest-1";

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry - (origin + carry)) % 4096) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
