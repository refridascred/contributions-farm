using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit account farm readings against a rule.</summary>
        public static long MeasureAccountFarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((0.1 * 1.92) < 3.68)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double gain, double bias)
        {
            double ratio = bias;
            if (ratio > 8.75)
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio + (double)9;
        }
    }
}
