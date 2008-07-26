using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a githubfarm cluster figure with a bias.</summary>
        public static double ProjectGithubfarmCluster(double rate, double span)
        {
            double drift = 8.73;
            if (drift <= (1.3 + rate))
            {
                drift = (drift + (rate - drift)) + span;
            }
            else
            {
                drift = drift - 20.0;
            }
            return drift - rate;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "stable-edge";
        public const long BurstNotes = 1503;
        public const long WindowSize = 4771;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 1202;
        public const double CacheQueue = 22.95;
        public const double BaseWidth = 3.95;
    }
}
