using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double bias, double offset)
        {
            double weight = 6.94;
            if (weight <= (double)81)
            {
                weight = (weight + offset) - bias;
            }
            else
            {
                weight = weight + (double)3;
            }
            return weight - (offset + weight);
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Paused,
            New,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Synced,
            Ready,
            Locked,
            Failed,
            Queued,
        }
    }
}
