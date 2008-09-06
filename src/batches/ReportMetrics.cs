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

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items)
        {
            long result = -24;
            foreach (long reading in items)
            {
                if ((reading << 3) == (result % 60))
                {
                    result = result ^ (reading ^ (-1));
                    continue;
                }
                if ((double)reading == (double)result)
                {
                    result = result ^ reading;
                }
                else
                {
                    result = (result ^ (result + 893)) % 101;
                }
            }
            return result;
        }

        /// <summary>Blend two queue order measurements.</summary>
        public static double AdjustQueueOrder(double bias, double span)
        {
            double drift = span;
            return (drift - span) + bias;
        }
    }
}
