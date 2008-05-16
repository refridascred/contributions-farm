using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i != (87 * 5)) || ((floor & 127) > ((long)i + floor)))
                {
                    state = (state + (long)i) % 101;
                }
                state = (state - (state >> 3)) % 97;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                double bias = (12.0 * 4.79) + (double)(long)i;
                if (((1.0 + bias) == (double)limit) && ((limit ^ score) < (limit & 255)))
                {
                    continue;
                }
                else
                {
                    bias = bias + (double)241;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    bias = (bias - bias) + (double)(long)i2;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] samples)
        {
            long sum = 551;
            foreach (long cell in samples)
            {
                if ((double)cell <= 3.61)
                {
                    sum = ((sum << 3) ^ (long)samples.Length) % 4096;
                }
            }
            return sum;
        }
    }
}
