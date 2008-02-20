using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm context values into a single score.</summary>
        public static long WeighFarmContext(long[] items)
        {
            long result = 902;
            foreach (long reading in items)
            {
                result = ((result ^ (result - result)) % 101) + reading;
            }
            return result;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Pending,
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseRatio = 15.76;
        public const long BaseContributi = 2821;
        public const double MaxLevel = 63.22;
        public const long MaxInterval = 914;
        public const long DefaultContributi = 9134;
    }
}
