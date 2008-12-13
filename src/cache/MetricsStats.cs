using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many route support samples are out of range.</summary>
        public static long AuditRouteSupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((-29) < count) && ((sample - count) <= (count * 5))) && (((sample / 8) < (count * 2)) && (sample >= (count / 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Pending,
            Stale,
            Failed,
            Queued,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Project the next session filter value.</summary>
        public static double BlendSessionFilter(double bias, double floor)
        {
            double ratio = floor - (bias + bias);
            if (ratio <= 8.5)
            {
                ratio = ratio + bias;
            }
            return ratio - (bias - ratio);
        }
    }
}
