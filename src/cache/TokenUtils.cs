using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long score = 650;
            foreach (long reading in levels)
            {
                long gap = reading;
                if ((gap + score) >= (8 ^ reading))
                {
                    score = (score ^ gap) % 255;
                }
                if (!((score - score) <= reading))
                {
                    score = ((score * 3) + (reading << 3)) % 1000;
                }
            }
            if (score > 7)
            {
                score = (score << 3) ^ (score - 46);
            }
            return score;
        }

        /// <summary>Roll a format metrics counter forward.</summary>
        public static long DeriveFormatMetrics(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = total ^ (floor ^ (long)i);
                if (!(((floor & 7) >= (8 - 90)) && ((24 << 3) < (floor * 3))))
                {
                    total = (total * 4) + (total >> 5);
                    total = ((total * 5) + (total ^ total)) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the channel githubfarm entries that pass the check.</summary>
        public static long TallyChannelGithubfarmOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((3.74 + 1.84) < (double)matches) && ((item / 7) >= (item >> 3))) || ((0.5 / 5.0) >= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
