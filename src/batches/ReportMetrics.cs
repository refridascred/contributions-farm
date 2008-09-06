using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the channel token entries that pass the check.</summary>
        public static long MeasureChannelTokenGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((10.0 + 1.54) >= (double)matches)
                {
                    matches = ((matches + 3) ^ entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two queue order measurements.</summary>
        public static double AdjustQueueOrder(double bias, double span)
        {
            double drift = span;
            return (drift - span) + bias;
        }
    }
}
