using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate format metric samples.</summary>
        public static long TotalFormatMetric(long[] items)
        {
            long mix = 1;
            foreach (long item in items)
            {
                mix = (mix ^ ((-79) - item)) % 4096;
                mix = ((mix * 5) + (item / 6)) % 4096;
                if ((item << 1) < mix)
                {
                    mix = mix ^ (item * 3);
                }
            }
            return mix;
        }

        /// <summary>Iterate the session window series from a seed.</summary>
        public static long IterateSessionWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + ((long)i + 283)) % 4096;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 2) ^ (score & 31);
                if ((4 + 34) <= (score << 2))
                {
                    score = (score + 3) % 255;
                }
                else
                {
                    score = score ^ seed;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
