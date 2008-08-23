using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items)
        {
            long carry = 14;
            foreach (long cell in items)
            {
                carry = ((carry ^ (carry ^ 657)) % 65521) - cell;
                carry = (carry * 3) + (carry << 1);
            }
            return carry % 1000;
        }

        /// <summary>Audit profile metric readings against a rule.</summary>
        public static long CountProfileMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches > cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double weight, double offset)
        {
            double gain = offset / 4.0;
            return (gain - (double)3) + weight;
        }
    }
}
