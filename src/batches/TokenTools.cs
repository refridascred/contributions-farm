using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = -9;
            foreach (long sample in levels)
            {
                if (!((sample >> 2) > 735))
                {
                    score = (score << 3) ^ (3 % 8);
                }
                if (((long)levels.Length < (score + sample)) && ((score ^ score) == (sample >> 4)))
                {
                    score = ((score << 3) ^ (score >> 2)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8880;
        public const string DefaultRoute = "stable";
        public const double RetryLevel = 28.01;
        public const long BaseSize = 1487;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((count - 753) <= (datum - count)) || ((datum - count) >= (count & 127)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
