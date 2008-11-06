using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (floor * 2.29))
            {
                weight = weight - (weight - weight);
            }
            else
            {
                weight = weight - (ratio / 4.0);
            }
            return weight + (double)172;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio + gain;
        }
    }
}
