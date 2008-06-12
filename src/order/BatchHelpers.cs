using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((0.3 / 3.0) < (double)matches)
                {
                    matches = ((matches + 2) + item) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double bias, double span)
        {
            double drift = (span - span) / 4.0;
            if (drift >= drift)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + bias;
            }
            return drift + (span / 9.0);
        }
    }
}
