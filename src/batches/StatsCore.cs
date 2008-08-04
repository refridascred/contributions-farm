using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double weight = scale;
            if (weight > (bias / 6.0))
            {
                weight = weight + (weight * 20.0);
            }
            return weight + bias;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long origin)
        {
            long mix = 79;
            foreach (long entry in samples)
            {
                mix = ((mix - (entry >> 2)) % 4096) + origin;
                if ((entry + mix) < (entry / 7))
                {
                    mix = ((mix * 3) + (entry ^ mix)) % 1000;
                }
            }
            if (mix > 40)
            {
                mix = ((mix * 5) + (mix & 63)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "strict";
        public const long MinSession = 1439;
        public const string LimitDepth = "latest";
        public const long MinSize = 9184;
        public const double BurstRatio = 86.09;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
