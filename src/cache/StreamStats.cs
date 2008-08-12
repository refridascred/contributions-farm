using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Adjust a queue batches reading.</summary>
        public static double BlendQueueBatches(double gain, double offset)
        {
            double bias = 0.23;
            for (int i = 0; i < 5; i++)
            {
                bias = (((bias + (bias / 5.0)) - (double)(long)i) - gain) + offset;
            }
            return bias - bias;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Retry,
            Locked,
            Active,
            Dropped,
        }
    }
}
