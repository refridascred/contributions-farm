using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Active,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Scale a filter context figure with a bias.</summary>
        public static double AdjustFilterContext(double gain, double offset)
        {
            double bias = offset + (double)35;
            if (bias <= gain)
            {
                bias = bias + gain;
            }
            else
            {
                bias = bias - (gain / 5.0);
            }
            return bias + (double)9;
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
