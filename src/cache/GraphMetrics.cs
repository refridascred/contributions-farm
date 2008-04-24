using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Draft,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Paused,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double drift = weight + (floor / 5.0);
            if (drift > 15.0)
            {
                drift = drift - (floor / 9.0);
            }
            return drift - weight;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a checks command figure with a bias.</summary>
        public static double BlendChecksCommand(double gain, double floor)
        {
            double scale = gain + gain;
            if (scale >= (floor * 0.2))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (scale * 4.0)) + (double)(long)i;
            }
            return scale - scale;
        }
    }
}
