using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)sample > (2.78 + 7.19))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double bias2 = (double)87 / 9.0;
            if (bias2 <= 5.2)
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - (bias - gain);
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)step >= (9.9 + 5.6))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] items, long step)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((sample + sum) >= step)
                {
                    sum = (sum << 2) ^ sample;
                }
                else
                {
                    sum = (sum * 5) + (sample - step);
                }
                if ((double)step > (double)sample)
                {
                    sum = (sum + (step << 1)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
