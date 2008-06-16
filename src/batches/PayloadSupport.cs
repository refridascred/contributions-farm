using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a githubfarm token figure with a bias.</summary>
        public static double ProjectGithubfarmToken(double rate, double bias)
        {
            double weight = bias + (rate / 9.0);
            if (weight <= bias)
            {
                weight = weight + (double)90;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (double)8;
        }
    }
}
