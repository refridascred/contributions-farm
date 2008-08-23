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

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double weight, double offset)
        {
            double gain = offset / 4.0;
            return (gain - (double)3) + weight;
        }
    }
}
