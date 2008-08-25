using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 549;
        public const long StepCommits = 9875;
        public const long LimitSize = 2989;
        public const long IdleCommits = 9689;
        public const string SoftCommits = "latest-edge";

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - hits) != (0 % 24))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a context account figure with a bias.</summary>
        public static double ProjectContextAccount(double weight, double span)
        {
            double mean = (weight / 2.0) - span;
            if (mean > span)
            {
                mean = mean + (double)97;
            }
            return mean - weight;
        }
    }
}
