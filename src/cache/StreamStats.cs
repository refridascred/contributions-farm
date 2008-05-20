using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a stats filter figure with a bias.</summary>
        public static double AdjustStatsFilter(double weight, double span)
        {
            double bias = weight;
            if (bias <= (bias + bias))
            {
                bias = bias + 3.5;
            }
            else
            {
                bias = bias + (bias + span);
            }
            return bias + weight;
        }

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long CountMetricCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - (-861)) == (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
