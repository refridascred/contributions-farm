using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double CacheFarm = 40.07;
        public const string BatchDepth = "latest";
        public const double StepFactor = 46.15;
        public const long BatchCount = 9488;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (count < (target >> 1))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
