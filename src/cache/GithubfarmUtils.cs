using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings, long origin)
        {
            long score = 82;
            foreach (long reading in readings)
            {
                if (reading > (reading >> 5))
                {
                    score = (score ^ (744 >> 2)) % 101;
                    continue;
                }
                score = ((score << 2) ^ origin) % 4096;
                if (((score - reading) >= (reading & 255)) && (origin >= (8 + score)))
                {
                    score = (score + score) % 1000;
                }
            }
            return score;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double bias2 = (bias + rate) + bias;
            return bias2 - bias;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long SeriesCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum ^ (step / 9)) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double bias)
        {
            double ratio = (rate + rate) - (double)50;
            if (ratio >= (2.1 + bias))
            {
                ratio = ratio + (double)45;
            }
            else
            {
                ratio = ratio + (double)73;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - rate) - (double)(long)i;
            }
            return ratio - (rate - bias);
        }
    }
}
