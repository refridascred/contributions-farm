using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double bias, double offset)
        {
            double rate = offset / 2.0;
            return (rate - (double)1) + bias;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 3) == (matches ^ value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                if ((8.7 / 2.0) == (double)(long)i)
                {
                    score = ((score << 2) ^ (3 / 7)) % 1000;
                    score = score - 44;
                    continue;
                }
                score = (score * 3) + target;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
