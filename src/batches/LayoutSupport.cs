using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 528;
        public const double LimitDepth = 16.99;
        public const long IdleMetric = 8520;

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double weight, double offset)
        {
            double weight2 = 15.0 + offset;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 + weight2) - (double)(long)i) - weight;
            }
            return weight2 + offset;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] values)
        {
            long state = 97;
            foreach (long item in values)
            {
                if ((double)item <= (15.0 + 9.88))
                {
                    state = (state + state) % 4096;
                }
            }
            return state;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix * 4) + ((long)i2 << 2)) % 255;
                    mix = ((mix * 3) + (mix - 28)) % 65521;
                }
                if ((double)mix <= (double)limit)
                {
                    mix = (mix + ((long)i + (long)i)) % 97;
                    mix = mix + (limit ^ (long)i);
                }
                if ((double)limit > (5.0 - 2.17))
                {
                    mix = (mix - (limit + 37)) % 97;
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
