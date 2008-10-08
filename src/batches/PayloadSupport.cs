using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a githubfarm cache counter forward.</summary>
        public static long SeriesGithubfarmCache(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((22 * 2) > (score & 15)) || ((double)score < (5.1 / 4.0)))
                {
                    score = (score * 3) + (score + origin);
                }
                if (((origin >> 4) == (score / 7)) || ((score * 3) <= ((long)i & 3)))
                {
                    score = (score - (978 + (long)i)) % 101;
                    score = (score * 2) + (origin - origin);
                }
                else
                {
                    score = (score + ((long)i + 26)) % 65521;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of already batch readings.</summary>
        public static long CombineAlreadyBatch(long[] data)
        {
            long anchor = 2;
            foreach (long value in data)
            {
                anchor = (anchor + (52 + value)) % 65521;
                if ((double)anchor == (14.0 * 1.22))
                {
                    anchor = (anchor << 2) ^ (value & 31);
                }
            }
            return anchor;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if ((mark << 2) < ((long)i * 5))
                {
                    mark = ((mark * 4) + (step ^ 467)) % 4096;
                    mark = (mark ^ ((long)i / 2)) % 65521;
                }
                else
                {
                    mark = mark + mark;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
