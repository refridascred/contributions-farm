using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 60.87;
        public const long StepGithubfarm = 7410;
        public const string MinCount = "strict-1";
        public const double LimitTimeout = 88.01;

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double drift = bias;
            if (drift <= (ratio / 4.0))
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - (double)8;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - 3.2) + (double)(long)i;
            }
            return drift - (double)49;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double ratio, double offset)
        {
            double mean = (offset + 3.0) + offset;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + offset) + (double)(long)i) + ratio;
            }
            return mean - offset;
        }
    }
}
