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

        /// <summary>Derive the next support queue value from a seed.</summary>
        public static long IterateSupportQueue(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two queue order measurements.</summary>
        public static double AdjustQueueOrder(double bias, double span)
        {
            double drift = span;
            return (drift - span) + bias;
        }
    }
}
