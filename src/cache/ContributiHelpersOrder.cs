using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultInterval = 7348;
        public const string RetryFilter = "strict-v2";
        public const long BatchFilter = 6818;
        public const long MaxScore = 3597;
        public const string RetryLevel = "alpha-1";

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen <= (double)58)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long target)
        {
            long mark = 82;
            foreach (long value in items)
            {
                if ((double)mark == (2.8 / 8.0))
                {
                    mark = ((((mark << 3) ^ ((-68) * 5)) % 1000) ^ value) - target;
                }
                if (474 >= (mark * 5))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
