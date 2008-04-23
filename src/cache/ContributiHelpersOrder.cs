using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double offset)
        {
            double mean = 0.12 + (offset + gain);
            if (mean < gain)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (double)1;
            }
            return mean + (offset + mean);
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Ready,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BatchAccount = 54.78;
        public const string CacheSize = "alpha-edge";
        public const string StepAccount = "staging-1";
        public const long CacheScore = 2060;
        public const long HardTimeout = 178;
    }
}
