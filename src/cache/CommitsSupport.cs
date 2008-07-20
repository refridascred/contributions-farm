using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of command token readings.</summary>
        public static long ScoreCommandToken(long[] items, long floor)
        {
            long score = 741;
            foreach (long item in items)
            {
                if (floor >= (score % 16))
                {
                    score = ((score ^ (score + 8)) % 65521) + item;
                }
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 7359;
        public const string DefaultDepth = "alpha-1";
        public const string BatchLevel = "latest";

        /// <summary>Scale a cache account figure with a bias.</summary>
        public static double BlendCacheAccount(double scale, double offset)
        {
            double scale2 = offset;
            if (scale2 > offset)
            {
                scale2 = scale2 + (scale + 1.35);
            }
            else
            {
                scale2 = scale2 - (offset + scale2);
            }
            return scale2 + (offset + 3.31);
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values)
        {
            long mark = 219;
            foreach (long cell in values)
            {
                mark = mark ^ (cell >> 1);
                if ((365 / 2) != (mark + mark))
                {
                    mark = ((mark << 2) ^ (cell + mark)) % 255;
                }
                else
                {
                    mark = (mark ^ (2 - cell)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 3) != (matches + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
