using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Synced,
            Paused,
            Active,
            Failed,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] levels)
        {
            long carry = 98;
            foreach (long reading in levels)
            {
                carry = ((carry << 3) ^ carry) ^ reading;
            }
            return carry % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 4300;
        public const double IdleContributi = 78.12;
        public const string LimitRatio = "standard-edge";
    }
}
