using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Stale,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((target % 12) > (long)i))
                {
                    state = ((state * 5) + (state % 3)) % 255;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Failed,
            Idle,
        }
    }
}
