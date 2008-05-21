using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 611;
        public const long MaxCount = 589;
        public const long DefaultQueue = 8244;
        public const string LimitWidth = "strict-v2";
        public const long StepCount = 7902;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double weight, double floor)
        {
            double scale = weight;
            if (scale >= (floor - 2.87))
            {
                scale = scale - (double)318;
            }
            else
            {
                scale = scale - (double)2;
            }
            return scale + floor;
        }
    }
}
