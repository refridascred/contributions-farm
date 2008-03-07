using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Total { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a queue filter figure with a bias.</summary>
        public static double ProjectQueueFilter(double gain, double floor)
        {
            double load = (double)(99 / 4);
            if (load < gain)
            {
                load = load - (3.7 * 9.12);
            }
            else
            {
                load = load + (gain / 9.0);
            }
            return load + floor;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
