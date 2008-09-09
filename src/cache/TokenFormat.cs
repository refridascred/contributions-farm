using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Find the first cache already entry that matches the target.</summary>
        public static long LookupCacheAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Idle,
            Draft,
            Retry,
            Queued,
        }
    }
}
