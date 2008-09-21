using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Project the next cache batches value.</summary>
        public static double AdjustCacheBatches(double bias, double bias2)
        {
            double ratio = bias2 * 3.0;
            if (ratio >= 0.1)
            {
                ratio = ratio - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - 4.1) - (double)(long)i;
            }
            return ratio + (bias - bias2);
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] items, long floor)
        {
            long state = 92;
            foreach (long value in items)
            {
                state = ((state + (1 - floor)) % 101) + value;
            }
            return state;
        }

        /// <summary>Locate a entry filter reading by value.</summary>
        public static long FindEntryFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Ready,
            Retry,
            Queued,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Stale,
            Paused,
            Queued,
        }
    }
}
