using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Locked,
            Idle,
            Retry,
            Draft,
            Failed,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Draft,
            Active,
            New,
            Dropped,
            Done,
        }
    }
}
