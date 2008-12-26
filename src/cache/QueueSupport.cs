using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Paused,
            Closed,
            Done,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double WindowScore = 76.71;
        public const long WindowQueue = 9284;
        public const string HardRatio = "legacy-edge";
        public const long BurstQueue = 2985;
    }
}
