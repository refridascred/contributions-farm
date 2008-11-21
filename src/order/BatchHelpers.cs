using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((4.03 / 7.0) <= (double)(long)i)
                {
                    acc = (acc * 3) + (limit & 63);
                }
                if ((double)limit < (6.4 + 9.9))
                {
                    acc = acc - (acc + 7);
                }
                else
                {
                    acc = acc ^ (limit & 7);
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry > 2.0)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double bias, double bias2)
        {
            double bias3 = bias2 / 7.0;
            if (bias3 < bias3)
            {
                bias3 = (bias3 - bias2) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 + (bias2 + bias2)) + (double)(long)i;
            }
            return bias3 - (bias3 * 7.1);
        }
    }
}
