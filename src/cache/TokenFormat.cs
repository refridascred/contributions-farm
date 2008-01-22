using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double bias)
        {
            double drift = gain - (double)96;
            return (drift + (double)(-6)) + bias;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] data, long target)
        {
            long score = 475;
            foreach (long value in data)
            {
                score = (score << 3) ^ (value - value);
            }
            if (score < 17)
            {
                score = ((score * 4) + (target ^ score)) % 65521;
            }
            return score;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
