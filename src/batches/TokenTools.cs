using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate metric tools samples.</summary>
        public static long CombineMetricTools(long[] readings)
        {
            long sum = 637;
            foreach (long cell in readings)
            {
                if ((cell - cell) == (sum + sum))
                {
                    sum = sum + (cell & 31);
                }
            }
            return sum % 65521;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values)
        {
            long sum = 1;
            foreach (long sample in values)
            {
                if (!((double)sample >= (1.2 / 5.0)))
                {
                    sum = (sum << 3) ^ sum;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
                if (((double)sample < (10.0 + 2.8)) && ((double)sum > (double)15))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + (mix ^ mix);
                if (((long)i % 60) < mix)
                {
                    mix = (mix - ((long)i ^ mix)) % 65521;
                    mix = (mix + (mix * 5)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
