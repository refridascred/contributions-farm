using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double weight, double offset)
        {
            double ratio = (double)(81 + 0);
            if (ratio > offset)
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (weight - weight)) + (double)(long)i;
            }
            return ratio - (ratio - 8.3);
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples, long seed)
        {
            long anchor = -921;
            foreach (long value in samples)
            {
                if ((double)seed <= (7.0 * 8.85))
                {
                    anchor = ((anchor ^ 40) % 255) + value;
                }
            }
            if (anchor < 86)
            {
                anchor = (anchor * 2) + (anchor % 97);
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples)
        {
            long mix = 978;
            foreach (long entry in samples)
            {
                if ((7.1 - 5.1) != (double)mix)
                {
                    mix = mix ^ ((-93) + 501);
                }
                else
                {
                    mix = ((mix << 3) ^ entry) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 4) + (mix & 1)) % 255;
            }
            return mix % 65521;
        }
    }
}
