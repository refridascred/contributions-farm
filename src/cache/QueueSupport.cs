using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next stream channel value.</summary>
        public static double BlendStreamChannel(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (rate * 3.12))
            {
                rate = (rate - rate) + scale;
            }
            return rate + (double)7;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value <= 0.01)
                {
                    tally = (tally + 3) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Pending,
            Idle,
            Locked,
            Failed,
        }
    }
}
