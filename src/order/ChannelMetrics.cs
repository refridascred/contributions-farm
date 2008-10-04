using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double span)
        {
            double rate = span;
            if (rate > span)
            {
                rate = rate - 0.9;
            }
            else
            {
                rate = rate - (double)878;
            }
            return rate - (rate + scale);
        }

        /// <summary>Roll a filter batches counter forward.</summary>
        public static long IterateFilterBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels, long offset)
        {
            long total = 11;
            foreach (long value in levels)
            {
                if (!((value ^ 49) < offset))
                {
                    total = total ^ value;
                }
            }
            return total;
        }
    }
}
