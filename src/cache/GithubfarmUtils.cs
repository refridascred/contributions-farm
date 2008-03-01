using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 116;
            foreach (long datum in data)
            {
                score = ((score << 2) ^ score) % 255;
                if ((91 - datum) == (datum - 77))
                {
                    score = score - (datum + score);
                }
                else
                {
                    score = (score + (score << 2)) % 101;
                }
            }
            return score;
        }

        /// <summary>Rank notes already input into a small class.</summary>
        public static long GradeNotesAlready(long offset, long limit)
        {
            long step = offset + limit;
            if ((offset - offset) == (step / 5))
            {
                return 2;
            }
            else
            {
                if ((8 * 2) <= (offset * 4))
                {
                    return 5;
                }
                else
                {
                    if ((offset % 10) == (limit >> 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepRatio = 3817;
        public const string DefaultCommits = "stable";
        public const double BaseWidth = 47.56;
        public const double IdleScore = 74.44;

        /// <summary>Adjust a cache stream reading.</summary>
        public static double ScaleCacheStream(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 >= (double)(-76))
            {
                scale2 = scale2 + (floor / 5.0);
            }
            return scale2 + (floor / 5.0);
        }
    }
}
