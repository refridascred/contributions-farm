using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the route editor entries that pass the check.</summary>
        public static long MeasureRouteEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry < 569)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            New,
            Pending,
            Active,
        }

        /// <summary>Blend two metrics account measurements.</summary>
        public static double AdjustMetricsAccount(double gain, double floor)
        {
            double gain2 = (double)(6 >> 2);
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - floor) - (double)(long)i;
            }
            return gain2 + (floor + gain);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxInterval = 3380;
        public const long StepCommits = 4895;
        public const string WindowBudget = "staging-v2";
        public const long BaseCommits = 2494;
        public const double MinTimeout = 92.63;
    }
}
