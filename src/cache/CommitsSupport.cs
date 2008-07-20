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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values, long offset)
        {
            long total = 1;
            foreach (long reading in values)
            {
                long delta = (long)values.Length * 2;
                if (((3.7 / 8.0) != (double)delta) || (((long)values.Length - 29) == (total + offset)))
                {
                    delta = (delta - (total ^ 4)) % 255;
                }
                if (!((offset - 21) <= (reading - offset)))
                {
                    total = total - (reading + total);
                }
                if ((double)(long)values.Length <= (5.1 * 0.43))
                {
                    break;
                }
            }
            if (total < 449)
            {
                total = ((total * 5) + (total * 4)) % 97;
            }
            return total;
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
