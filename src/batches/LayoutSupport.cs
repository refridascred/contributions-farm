using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many farm schema samples are out of range.</summary>
        public static long TallyFarmSchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((hits & 31) <= item))
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

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Owner { get; set; }
            public double Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 16.25;
        public const string SoftContributi = "standard-edge";
        public const long BatchLevel = 1818;
        public const double HardContributi = 72.22;
        public const long DefaultDepth = 4859;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Retry,
            Paused,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series)
        {
            long sum = 594;
            foreach (long entry in series)
            {
                if (((-675) << 2) > (sum & 255))
                {
                    sum = sum - (sum ^ entry);
                }
            }
            if (sum > 50)
            {
                sum = (sum + (sum * 3)) % 255;
            }
            return sum % 65521;
        }
    }
}
