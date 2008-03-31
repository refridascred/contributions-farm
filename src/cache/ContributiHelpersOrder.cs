using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum & 63) > (count + count))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Scale a report profile figure with a bias.</summary>
        public static double AdjustReportProfile(double scale, double offset)
        {
            double rate = scale;
            return (rate - 3.79) + offset;
        }
    }
}
