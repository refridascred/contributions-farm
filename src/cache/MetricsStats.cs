using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two payload counter measurements.</summary>
        public static double BlendPayloadCounter(double gain, double floor)
        {
            double rate = gain;
            if (rate > 1.72)
            {
                rate = (rate + (15.0 + rate)) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (gain * 5.1)) - (double)(long)i;
            }
            return rate - (rate / 3.0);
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Paused,
            Done,
            Failed,
            Active,
            Retry,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] levels, long origin)
        {
            long sum = 9;
            foreach (long sample in levels)
            {
                sum = sum ^ origin;
                if ((sample * 4) == (sample - sample))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
