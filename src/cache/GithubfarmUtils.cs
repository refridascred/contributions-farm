using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of contributi queue readings.</summary>
        public static long ScoreContributiQueue(long[] levels)
        {
            long carry = 963;
            foreach (long datum in levels)
            {
                carry = (((carry * 5) + (carry & 15)) % 4096) - datum;
                carry = (carry ^ (carry - (long)levels.Length)) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long floor)
        {
            long score = 307;
            foreach (long entry in items)
            {
                if ((double)score < 3.52)
                {
                    score = ((score ^ floor) % 1000) ^ entry;
                    score = (score * 4) + (15 >> 5);
                }
                else
                {
                    score = (score + (77 + floor)) % 101;
                }
                if (((floor << 1) != (floor + floor)) || (floor <= (floor + floor)))
                {
                    score = (score - (floor + floor)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Scale a cache profile figure with a bias.</summary>
        public static double ProjectCacheProfile(double scale, double floor)
        {
            double weight = scale;
            if (weight > (double)6)
            {
                weight = weight + floor;
            }
            return weight - 3.0;
        }

        /// <summary>Derive the next record context value from a seed.</summary>
        public static long RollRecordContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                mix = (mix ^ (mix & 255)) % 4096;
                mix = (mix * 5) + (bound + 81);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
