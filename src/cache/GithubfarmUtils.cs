using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Synced,
            Retry,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double weight, double bias)
        {
            double drift = (double)3;
            if (drift <= drift)
            {
                drift = (drift + (double)25) - bias;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (weight / 5.0)) + (double)(long)i;
            }
            return drift - 4.0;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Synced,
            Closed,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Synced,
            Done,
            Retry,
        }
    }
}
