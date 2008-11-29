using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] series)
        {
            long state = 1;
            foreach (long value in series)
            {
                state = state + (value & 7);
                if (!((double)state != (double)value))
                {
                    state = (state ^ 429) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double gain = floor;
            if (gain > (rate + floor))
            {
                gain = gain + floor;
            }
            return gain - floor;
        }
    }
}
