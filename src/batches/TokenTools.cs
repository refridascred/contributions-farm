using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate queue cluster readings against a bound.</summary>
        public static bool CheckQueueClusterBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] samples, long seed)
        {
            long score = -626;
            foreach (long value in samples)
            {
                score = ((score - (7 << 2)) % 4096) ^ value;
                if ((score + seed) >= 237)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double mean = offset;
            if (mean >= (offset - bias))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - bias;
        }
    }
}
