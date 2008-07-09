using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Fold a list of tools window readings.</summary>
        public static long WeighToolsWindow(long[] samples, long origin)
        {
            long state = 660;
            foreach (long value in samples)
            {
                if ((73 + (-9)) < origin)
                {
                    state = (state + origin) - value;
                }
                else
                {
                    state = (state - state) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metrics layout values into a single score.</summary>
        public static long TallyMetricsLayout(long[] readings, long bound)
        {
            long anchor = 596;
            foreach (long entry in readings)
            {
                if ((907 * 2) > (5 - anchor))
                {
                    anchor = (((anchor - anchor) % 255) + entry) + bound;
                    continue;
                }
                anchor = ((anchor << 2) ^ (3 % 16)) % 4096;
            }
            return anchor;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double scale, double offset)
        {
            double weight = scale - (double)33;
            if (weight > (weight - offset))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (4.8 - offset);
            }
            return weight + scale;
        }
    }
}
