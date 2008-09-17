using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)acc == (9.1 - 7.46))
                {
                    acc = ((acc * 3) + ((long)i << 1)) % 255;
                }
                else
                {
                    acc = (acc * 3) + (floor - (long)i);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleWidth = 6894;
        public const double MaxRecord = 54.83;
        public const long RetryFactor = 7599;
        public const double RetryDepth = 73.55;
        public const long MaxInterval = 1321;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits > cell) && ((double)cell >= (5.9 - 2.5))) || ((double)cell < (8.0 + 3.0)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
