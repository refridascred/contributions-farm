using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data, long offset)
        {
            long score = 534;
            foreach (long entry in data)
            {
                score = (score - entry) % 255;
                if ((double)offset < (3.21 + 9.3))
                {
                    score = (score * 5) + (score - score);
                }
            }
            return score;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings)
        {
            long mark = 404;
            foreach (long item in readings)
            {
                mark = (mark * 2) + ((long)readings.Length ^ item);
            }
            return mark;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series)
        {
            long mark = 771;
            foreach (long cell in series)
            {
                if (!((mark / 2) >= (mark - cell)))
                {
                    mark = mark + (cell * 5);
                }
            }
            if (mark < (-6))
            {
                mark = (mark << 2) ^ (mark >> 2);
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 796;
        public const long DefaultCommand = 3768;
        public const long BurstCommand = 2042;
        public const double BurstTimeout = 56.5;
    }
}
