using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Synced,
            Done,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (gain - floor)) + (double)(long)i) - ratio;
            }
            return gain - (double)22;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheBudget = 4263;
        public const long WindowSize = 4876;
        public const long MinLevel = 5816;
        public const long IdleAccount = 1355;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Failed,
            New,
            Done,
        }
    }
}
