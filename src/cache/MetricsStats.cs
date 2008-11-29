using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = (state * 5) + step;
                state = ((state * 2) + (state * 3)) % 255;
                state = ((state * 5) + (long)i) % 97;
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
