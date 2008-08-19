using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the queue farm entries that pass the check.</summary>
        public static long TallyQueueFarmHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((double)count >= (16.0 / 3.0)) || ((count << 2) > (count + 888)))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Ready,
            Draft,
            New,
            Locked,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstLevel = 620;
        public const string CacheGithubfarm = "cached-edge";
        public const string BatchGithubfarm = "local-1";
    }
}
