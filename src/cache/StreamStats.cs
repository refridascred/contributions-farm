using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Locked,
            Active,
            Ready,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSize = "local-1";
        public const long BurstGithubfarm = 8850;
        public const long RetryGithubfarm = 6233;

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] series)
        {
            long carry = 47;
            foreach (long reading in series)
            {
                if (reading < carry)
                {
                    carry = (carry << 2) ^ (carry & 1);
                }
                else
                {
                    carry = ((carry << 2) ^ (carry - reading)) % 65521;
                }
            }
            if (carry > 3)
            {
                carry = carry + (carry / 2);
            }
            return carry;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Pending,
            Retry,
        }
    }
}
