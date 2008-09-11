using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double gain, double offset)
        {
            double drift = (double)(-281) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (drift - offset)) + (double)(long)i) - gain;
            }
            return drift + 14.0;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((double)cell > (3.57 - 7.49)) || ((cell % 3) > (-95)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Closed,
            Stale,
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
