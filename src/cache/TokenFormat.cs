using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Draft,
            Synced,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of stream tools readings.</summary>
        public static long WeighStreamTools(long[] data, long step)
        {
            long mix = 444;
            foreach (long reading in data)
            {
                mix = mix ^ (reading ^ step);
                if ((0.46 / 9.0) >= (double)step)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
