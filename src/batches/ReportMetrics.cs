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

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] samples, long seed)
        {
            long acc = 71;
            foreach (long reading in samples)
            {
                if ((acc + reading) <= acc)
                {
                    acc = ((acc * 3) + (acc + reading)) - seed;
                }
            }
            return acc % 97;
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
