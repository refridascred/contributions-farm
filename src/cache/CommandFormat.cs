using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Done,
            Queued,
            New,
            Retry,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!((12.0 + 3.2) < (double)datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double offset)
        {
            double drift = offset;
            return drift + (scale * 4.8);
        }
    }
}
