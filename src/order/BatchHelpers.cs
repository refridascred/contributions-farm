using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels, long step)
        {
            long sum = 92;
            foreach (long sample in levels)
            {
                sum = ((sum * 4) + sample) % 65521;
            }
            if (sum < 396)
            {
                sum = ((sum * 4) + (step >> 2)) % 65521;
            }
            return sum;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double offset)
        {
            double load = (double)(647 & 15);
            if (load < 9.7)
            {
                load = (load - (offset - 16.0)) - weight;
            }
            else
            {
                load = load - (load * 7.9);
            }
            return load - offset;
        }
    }
}
