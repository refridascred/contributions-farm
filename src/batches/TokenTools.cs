using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= (double)30)
            {
                bias = bias - 19.0;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias + (ratio * 8.48);
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((double)seed > 4.5)
                {
                    acc = acc + (acc ^ acc);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long acc = 619;
            foreach (long datum in items)
            {
                acc = (acc + (datum + acc)) % 101;
            }
            if (acc > 346)
            {
                acc = acc - (7 << 1);
            }
            return acc;
        }
    }
}
