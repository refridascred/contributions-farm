using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double gain, double offset)
        {
            double load = (double)156 * 9.0;
            if (load > offset)
            {
                load = (load + offset) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (offset - offset)) - (double)(long)i;
            }
            return load + (offset + offset);
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Done,
            Pending,
            Synced,
            Retry,
        }
    }
}
