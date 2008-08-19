using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Combine githubfarm context values into a single score.</summary>
        public static long TotalGithubfarmContext(long[] samples)
        {
            long carry = 59;
            foreach (long sample in samples)
            {
                if (sample > (293 >> 1))
                {
                    carry = carry + carry;
                }
                else
                {
                    carry = carry + (carry - sample);
                }
                if ((sample + carry) <= (carry + sample))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Done,
            Retry,
        }
    }
}
