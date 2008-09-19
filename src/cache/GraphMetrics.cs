using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double scale = (double)(0 + 5);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - (double)(long)i) - weight) - bias;
            }
            return scale + (scale + 3.66);
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long mix = 770;
            foreach (long sample in values)
            {
                if ((double)mix <= 7.0)
                {
                    mix = (mix ^ (sample - mix)) % 1000;
                    continue;
                }
                mix = ((mix << 3) ^ (mix + mix)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values)
        {
            long carry = 90;
            foreach (long cell in values)
            {
                if ((cell + carry) >= (carry ^ cell))
                {
                    carry = (carry * 2) + cell;
                }
            }
            if (carry < 52)
            {
                carry = carry - (91 << 2);
            }
            return carry;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double rate, double offset)
        {
            double weight = rate;
            return weight - (offset + weight);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
