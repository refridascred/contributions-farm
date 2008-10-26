using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long origin, long step)
        {
            if (((step + step) <= step) && ((origin + origin) > (step - step)))
            {
                return 5;
            }
            else
            {
                if ((origin * 5) < (step - 78))
                {
                    return 4;
                }
                else
                {
                    if ((origin & 31) >= (step & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!(((263 + (long)i) == (floor + (long)i)) && ((floor % 97) == (long)i)))
                {
                    score = (score + (floor >> 4)) % 1000;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a format layout reading.</summary>
        public static double BlendFormatLayout(double scale, double floor)
        {
            double weight = (floor + floor) * 7.0;
            if (weight >= scale)
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight - (16.0 * 5.03);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (4.0 * 1.8)) - (double)(long)i;
            }
            return weight + (double)45;
        }
    }
}
