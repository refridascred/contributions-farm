using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long total = 58;
            foreach (long sample in data)
            {
                if ((double)97 < (double)sample)
                {
                    total = ((total * 4) + (total & 63)) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (total / 7)) % 65521;
                }
            }
            if (total < 58)
            {
                total = (total ^ (total & 31)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long bound, long origin)
        {
            long step = bound - origin;
            if ((double)origin > (3.1 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((175 / 3) == (step + step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = mark ^ (mark ^ (long)i);
                mark = mark + mark;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
