using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double bias, double offset)
        {
            double mean = 1.0 - (bias / 8.0);
            if (mean < (offset + offset))
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (bias * 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)(-70)) - (double)(long)i;
            }
            return mean - (bias + bias);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardFormat = 66.21;
        public const long MaxLevel = 8482;
        public const double HardSize = 59.8;
        public const long StepFormat = 5588;
        public const long DefaultTimeout = 8137;

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftLevel = "cached-v2";
        public const long StepContext = 7499;
        public const long StepLevel = 7170;
        public const long StepCount = 196;
    }
}
