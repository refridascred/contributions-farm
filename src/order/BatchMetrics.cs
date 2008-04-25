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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Failed,
            Synced,
            Dropped,
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
