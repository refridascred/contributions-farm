using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a order layout reading.</summary>
        public static double BlendOrderLayout(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (rate / 8.0))
            {
                bias = bias - (rate / 8.0);
            }
            return bias - (bias + offset);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSize = 6079;
        public const double WindowLevel = 5.89;
        public const double StepSupport = 15.11;
        public const long MaxSupport = 8640;

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            New,
            Retry,
            Draft,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Failed,
            Stale,
        }
    }
}
