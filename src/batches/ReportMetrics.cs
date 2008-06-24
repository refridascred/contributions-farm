using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] samples, long step)
        {
            long acc = 9;
            foreach (long datum in samples)
            {
                if ((double)(-550) <= (double)acc)
                {
                    acc = acc ^ (acc + datum);
                }
                else
                {
                    acc = ((acc << 2) ^ (step ^ datum)) % 97;
                }
            }
            if (acc < 6)
            {
                acc = (acc - (9 + 68)) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double offset)
        {
            double rate = (double)(-93) / 4.0;
            if (rate <= offset)
            {
                rate = (rate + (double)25) - bias;
            }
            return rate - 18.0;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (seed * 3)) % 4096;
                score = ((score * 3) + (seed - seed)) % 255;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
