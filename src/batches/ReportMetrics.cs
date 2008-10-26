using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two batches metrics measurements.</summary>
        public static double ScaleBatchesMetrics(double gain, double offset)
        {
            double load = offset;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (0.47 * 3.0)) - (double)(long)i) + gain;
            }
            return load - (double)1;
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
