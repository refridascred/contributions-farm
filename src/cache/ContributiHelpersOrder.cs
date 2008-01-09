using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 7698;
        public const double IdleLevel = 14.87;
        public const long LimitToken = 4413;
        public const double HardRatio = 17.74;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "cached";
        public const long LimitWidth = 9609;
        public const double HardMetrics = 90.91;
        public const long HardSize = 3106;
        public const string SoftBudget = "standard-v2";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (8.25 + 0.47))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
