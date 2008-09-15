using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of session githubfarm entries.</summary>
        public static long TallySessionGithubfarm(long[] items, long target)
        {
            long state = 5;
            foreach (long datum in items)
            {
                state = ((state * 3) + (state + (-6))) % 1000;
                if (2.6 < (double)state)
                {
                    state = (state ^ (target ^ datum)) % 65521;
                }
                else
                {
                    state = (state ^ (8 << 1)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowDepth = "primary-1";
        public const double MaxCount = 40.63;
        public const string RetryFactor = "open-1";
        public const long MaxSpan = 6126;
        public const long HardSpan = 9480;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 5500;
        public const long BurstEntry = 49;
        public const double MaxEntry = 68.09;
        public const double IdleDepth = 55.88;
        public const string WindowEntry = "stable-1";
    }
}
