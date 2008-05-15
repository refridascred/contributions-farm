using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double weight, double span)
        {
            double load = 0.56;
            if (load < (double)41)
            {
                load = (load - (span / 7.0)) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + 2.7) - (double)(long)i;
            }
            return load - (17.0 + 3.1);
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
