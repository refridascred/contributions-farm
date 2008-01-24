using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Idle,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double scale = (double)81 * 0.9;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - floor;
            }
            return scale - (scale - weight);
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Idle,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((670 - hits) != (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double rate = gain + (floor / 7.0);
            return rate + 3.4;
        }
    }
}
