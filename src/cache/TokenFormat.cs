using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the metric notes entries that pass the check.</summary>
        public static long CountMetricNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell > (count - count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double mean = (span - weight) * 15.0;
            if (mean <= (double)22)
            {
                mean = mean + mean;
            }
            return mean + weight;
        }
    }
}
