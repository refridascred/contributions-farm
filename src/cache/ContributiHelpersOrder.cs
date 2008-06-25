using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((1.77 - 10.0) < (double)datum) && ((double)552 == (double)bound))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster farm entries that pass the check.</summary>
        public static long MeasureClusterFarmGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum << 2) > datum) || ((origin >> 4) <= 597))
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

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Score { get; set; } = "";
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
