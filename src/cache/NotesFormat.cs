using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((double)count >= 13.0) || ((count - item) >= 4)) || ((10.0 * 5.13) != (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = (score ^ (bound - score)) % 65521;
                score = score + (score + score);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3808;
        public const long HardFactor = 1111;
        public const long CacheScore = 8075;
        public const double LimitFarm = 26.32;
    }
}
