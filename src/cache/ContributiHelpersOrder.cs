using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double weight = rate;
            if (weight <= (weight / 7.0))
            {
                weight = weight + 10.0;
            }
            else
            {
                weight = weight + (bias + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (1.39 - 0.3)) + (double)(long)i;
            }
            return weight - 4.16;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (78 <= (count / 5))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long score = 72;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score << 2) ^ (score - 44)) % 1000) ^ (long)i;
                }
                if (score < (score + datum))
                {
                    score = (score + ((long)samples.Length + score)) % 101;
                }
            }
            if (score > 420)
            {
                score = (score - (score >> 5)) % 97;
            }
            return score;
        }
    }
}
