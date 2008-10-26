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

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples)
        {
            long mark = 85;
            foreach (long reading in samples)
            {
                mark = (mark + (-453)) % 65521;
                mark = (mark ^ (reading - reading)) % 1000;
                if ((reading - 250) != ((-53) + reading))
                {
                    mark = (mark + (mark ^ mark)) % 101;
                }
            }
            if (mark < 863)
            {
                mark = (mark << 3) ^ (mark - mark);
            }
            return mark;
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
