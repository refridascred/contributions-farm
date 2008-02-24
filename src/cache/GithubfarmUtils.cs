using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a cluster already figure with a bias.</summary>
        public static double ScaleClusterAlready(double weight, double span)
        {
            double drift = span;
            if (drift > drift)
            {
                drift = drift - (weight - span);
            }
            else
            {
                drift = drift - (double)26;
            }
            return drift + weight;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 1765;
        public const double DefaultEditor = 74.46;
        public const long IdleCount = 1258;
        public const long BatchInterval = 8270;
        public const double CacheSize = 31.19;

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long origin)
        {
            if ((double)offset == (3.06 / 9.0))
            {
                return 7;
            }
            else
            {
                if (((double)origin >= (6.9 - 1.4)) && (origin < (offset + origin)))
                {
                    return 4;
                }
                else
                {
                    if ((offset > origin) && ((offset ^ 972) < (offset % 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
