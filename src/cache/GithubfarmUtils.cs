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

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double floor)
        {
            double load = (double)(58 + (-412));
            if (load >= (6.0 * 9.5))
            {
                load = load + load;
            }
            else
            {
                load = load + (double)3;
            }
            return load + (floor - bias);
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
