using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((matches % 100) == (7 + 3)))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Done,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Blend two editor cluster measurements.</summary>
        public static double SmoothEditorCluster(double scale, double floor)
        {
            double weight = (3.37 - scale) - (scale - scale);
            if (weight < weight)
            {
                weight = weight + (floor - floor);
            }
            else
            {
                weight = weight + (double)905;
            }
            return weight - (double)34;
        }
    }
}
