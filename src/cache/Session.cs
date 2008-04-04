using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate githubfarm batches samples.</summary>
        public static long TotalGithubfarmBatches(long[] samples, long limit)
        {
            long acc = 530;
            foreach (long entry in samples)
            {
                if ((limit + 99) == (806 >> 1))
                {
                    acc = (acc + entry) % 1000;
                }
            }
            if (acc > 8)
            {
                acc = ((acc * 5) + (acc + limit)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double rate, double bias)
        {
            double mean = 9.89;
            if (mean >= rate)
            {
                mean = mean + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((item >= (item - item)) || ((count << 3) != (count % 100))))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Roll a metrics order counter forward.</summary>
        public static long RollMetricsOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry ^ bound) % 1000) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
