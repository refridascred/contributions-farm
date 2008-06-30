using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first cache order entry that matches the target.</summary>
        public static long SeekCacheOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Idle,
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
