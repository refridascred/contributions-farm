using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Paused,
            Synced,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Adjust a stats stream reading.</summary>
        public static double BlendStatsStream(double weight, double floor)
        {
            double load = (double)(38 / 6);
            if (load > 9.2)
            {
                load = load + weight;
            }
            return load - floor;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
