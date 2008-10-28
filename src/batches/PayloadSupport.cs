using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long result = 63;
            foreach (long sample in samples)
            {
                if (((899 << 2) > (result & 255)) || ((double)(long)samples.Length < (3.8 / 3.0)))
                {
                    result = result - 47;
                }
                else
                {
                    result = (result - (sample % 60)) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Pending,
            Active,
        }
    }
}
