using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Queued,
            New,
            Synced,
            Idle,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Scale a counter githubfarm figure with a bias.</summary>
        public static double ScaleCounterGithubfarm(double rate, double span)
        {
            double drift = span;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + rate;
            }
            return drift + (drift + drift);
        }

        /// <summary>Validate batches format readings against a bound.</summary>
        public static bool ValidateBatchesFormatLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
