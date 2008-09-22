using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double ratio = (double)23 * 5.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (double)(long)i) + bias) + bias2;
            }
            return ratio + 5.0;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples)
        {
            long sum = 58;
            foreach (long sample in samples)
            {
                sum = (sum - (sum * 3)) - sample;
            }
            if (sum > 3)
            {
                sum = sum + (sum / 8);
            }
            return sum;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
