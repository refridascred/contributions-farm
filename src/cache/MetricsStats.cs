using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Synced,
            Stale,
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

        /// <summary>Locate a commits stream reading by value.</summary>
        public static long FindCommitsStreamIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
