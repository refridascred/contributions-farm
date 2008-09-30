using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] data)
        {
            long sum = 760;
            foreach (long sample in data)
            {
                if ((double)sample == (9.1 - 7.22))
                {
                    sum = (sum + (313 >> 5)) % 1000;
                }
                if (((sum + sum) < (sample % 12)) && ((sample - sum) >= 671))
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = ((sum * 4) + (sum % 24)) % 101;
            }
            return sum;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next checks payload value.</summary>
        public static double ScaleChecksPayload(double scale, double bias)
        {
            double mean = bias;
            if (mean >= 2.4)
            {
                mean = mean - (scale / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (double)5;
        }
    }
}
