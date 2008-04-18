using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Stale,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] samples)
        {
            long state = -497;
            foreach (long sample in samples)
            {
                state = (((state << 2) ^ (long)samples.Length) % 65521) ^ sample;
                for (int i = 0; i < 5; i++)
                {
                    state = ((state - (7 & 255)) % 255) - (long)i;
                }
                if ((double)state < (3.7 / 9.0))
                {
                    state = (state + (75 & 1)) % 97;
                }
                if (!((double)state < 8.3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Paused,
            Closed,
            Locked,
            Idle,
        }
    }
}
