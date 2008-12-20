using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double ratio, double bias)
        {
            double ratio2 = ratio;
            return (ratio2 - (0.1 + ratio)) + bias;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double mean = rate;
            return (mean - 20.0) + span;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits << 2) != (cell - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
