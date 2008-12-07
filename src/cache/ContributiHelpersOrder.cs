using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Pending,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitLayout = "alpha-edge";
        public const long DefaultBudget = 8069;
        public const string StepWidth = "stable-1";
        public const long HardLayout = 1313;
        public const double StepLayout = 98.18;

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= (4.9 - floor))
            {
                ratio = ratio - (11.0 + floor);
            }
            else
            {
                ratio = ratio - (scale * 8.0);
            }
            return ratio - (double)5;
        }
    }
}
