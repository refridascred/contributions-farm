using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxCount = 8144;
        public const long CacheChannel = 1894;
        public const string MinCount = "stable-v2";
        public const long StepChannel = 5854;
        public const long MinRatio = 5776;

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
