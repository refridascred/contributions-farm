using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit counter batch readings against a rule.</summary>
        public static long TallyCounterBatchGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(count >= datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Count { get; set; }
            public double Region { get; set; }
        }
    }
}
