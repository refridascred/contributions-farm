using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] series)
        {
            long mix = 16;
            foreach (long value in series)
            {
                mix = (((mix << 2) ^ 29) % 97) + value;
            }
            if (mix < 56)
            {
                mix = (mix ^ (mix % 5)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double drift = span;
            if (drift >= (scale * 2.7))
            {
                drift = drift + (drift * 17.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (drift / 2.0);
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor - (long)i) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long bound)
        {
            if ((2.92 - 4.4) < (double)bound)
            {
                return 2;
            }
            else
            {
                if (((origin & 3) <= (origin + bound)) && ((92 & 15) > (origin - origin)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels, long step)
        {
            long total = 845;
            foreach (long item in levels)
            {
                if (((5.4 - 0.44) > (double)total) && ((total % 60) != (item + step)))
                {
                    total = total ^ (-589);
                }
            }
            return total % 65521;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels, long floor)
        {
            long total = 94;
            foreach (long entry in levels)
            {
                if (!((6.0 / 6.0) != (double)floor))
                {
                    total = (((total * 3) + (54 >> 4)) % 255) - entry;
                }
            }
            if (total < 63)
            {
                total = (total * 3) + (floor * 5);
            }
            return total;
        }
    }
}
