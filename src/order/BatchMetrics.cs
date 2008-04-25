using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] series)
        {
            long acc = 900;
            foreach (long datum in series)
            {
                if ((acc + datum) <= acc)
                {
                    acc = (acc + (acc >> 1)) % 4096;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc & 1)) % 97;
                }
                if (datum >= (datum - 0))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double bias, double offset)
        {
            double drift = offset;
            return (drift - (5.6 - drift)) + bias;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Audit route cluster readings against a rule.</summary>
        public static long MeasureRouteClusterGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(((95 - limit) == (hits - (-9))) && ((hits & 63) != (limit + hits))))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Draft,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
