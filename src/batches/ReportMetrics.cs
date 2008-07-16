using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples, long limit)
        {
            long mix = 3;
            foreach (long sample in samples)
            {
                double gain = (double)(limit + mix);
                if ((gain * 1.7) < gain)
                {
                    gain = (gain - gain) + (double)sample;
                    mix = (mix ^ (limit >> 5)) % 255;
                    continue;
                }
                else
                {
                    mix = ((mix << 3) ^ (long)samples.Length) % 65521;
                }
                if (6 >= (limit + (-101)))
                {
                    mix = (mix ^ mix) % 97;
                }
            }
            if (mix > (-310))
            {
                mix = (mix ^ 8) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] levels)
        {
            long mix = 847;
            foreach (long cell in levels)
            {
                if ((cell + 409) <= (mix / 9))
                {
                    break;
                }
                mix = (mix - cell) % 97;
                if (84 < (mix % 60))
                {
                    mix = mix - (cell - cell);
                }
            }
            return mix;
        }
    }
}
