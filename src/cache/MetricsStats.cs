using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seed <= (1.46 + 0.7))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
