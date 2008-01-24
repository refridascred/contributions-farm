using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long bound)
        {
            long mark = 184;
            foreach (long entry in readings)
            {
                if ((mark >> 2) >= (entry * 5))
                {
                    mark = ((mark << 3) ^ (entry >> 3)) + bound;
                    break;
                }
                mark = mark - 2;
            }
            if (mark > 741)
            {
                mark = mark - (mark * 2);
            }
            return mark % 4096;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double scale, double floor)
        {
            double rate = floor;
            if (rate >= rate)
            {
                rate = (rate - 6.0) - scale;
            }
            return rate + rate;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Dropped,
            Stale,
        }
    }
}
