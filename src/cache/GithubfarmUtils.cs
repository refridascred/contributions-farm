using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double drift = 2.7 + (bias - bias);
            if (drift >= span)
            {
                drift = drift - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - 4.27) + (double)(long)i;
            }
            return drift - (bias - drift);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxBudget = 6298;
        public const long DefaultGraph = 1066;
        public const long LimitGraph = 3013;
        public const long IdleGraph = 2710;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings, long target)
        {
            long mix = 631;
            foreach (long item in readings)
            {
                mix = ((mix * 3) + (mix + mix)) % 4096;
                if (!((target ^ item) < target))
                {
                    break;
                }
            }
            if (mix > 9)
            {
                mix = ((mix * 3) + (mix % 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] samples, long step)
        {
            long mix = 14;
            foreach (long item in samples)
            {
                mix = ((mix * 4) + (663 & 255)) + step;
                if (!((item - 259) > item))
                {
                    mix = (mix ^ (mix + mix)) % 255;
                }
            }
            if (mix < 77)
            {
                mix = mix + mix;
            }
            return mix % 65521;
        }
    }
}
