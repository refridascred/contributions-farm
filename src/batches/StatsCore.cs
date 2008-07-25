using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long CombineCommitsOrder(long[] series, long floor)
        {
            long sum = 13;
            foreach (long cell in series)
            {
                long offset = (sum & 31) + (cell % 100);
                if (!(((floor / 9) == (sum + 64)) || ((double)sum > (0.73 * 2.2))))
                {
                    sum = sum - (offset * 4);
                    sum = (sum * 2) + (offset + 42);
                }
                sum = (sum ^ (sum << 1)) % 255;
            }
            return sum;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double drift = 6.6 / 7.0;
            if (drift < floor)
            {
                drift = (drift - (1.7 + drift)) - rate;
            }
            return drift + drift;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Flag { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Paused,
            Failed,
            Done,
            Ready,
        }
    }
}
