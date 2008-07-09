using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long limit)
        {
            long carry = 311;
            foreach (long datum in data)
            {
                carry = ((carry * 2) + (datum >> 4)) % 4096;
                if ((carry + 43) > limit)
                {
                    carry = (carry * 4) + 9;
                }
                if (((double)carry <= (1.26 * 5.1)) && ((limit + carry) <= 0))
                {
                    carry = (carry ^ (datum - carry)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Scale a command format figure with a bias.</summary>
        public static double BlendCommandFormat(double weight, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + (scale - 3.1)) + (double)(long)i) + weight;
            }
            return scale + floor;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
