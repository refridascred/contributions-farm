using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of context schema readings.</summary>
        public static long OverlapContextSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double offset)
        {
            double weight = ratio;
            return (weight + ratio) + offset;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long score = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score - (4 + score)) % 1000) ^ (long)i2;
                }
                if ((bound ^ (long)i) >= score)
                {
                    score = score - (score - bound);
                }
                else
                {
                    score = (score + (long)i) % 1000;
                    score = (score ^ (score - bound)) % 97;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
