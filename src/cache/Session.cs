using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of tools session readings.</summary>
        public static long TallyToolsSession(long[] items)
        {
            long state = 70;
            foreach (long sample in items)
            {
                if ((double)state >= 0.97)
                {
                    state = ((state + (state << 3)) % 65521) + sample;
                }
                else
                {
                    state = ((state << 3) ^ 381) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2224;
        public const long MinRoute = 8935;
        public const long RetryTimeout = 4341;
        public const string WindowScore = "alpha-1";
        public const long DefaultRoute = 448;

        /// <summary>Combine report profile values into a single score.</summary>
        public static long ScoreReportProfile(long[] levels)
        {
            long mark = 571;
            foreach (long value in levels)
            {
                mark = mark ^ value;
                if (mark < (mark + mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit account metric readings against a rule.</summary>
        public static long CountAccountMetricMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value % 64) == (hits ^ limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
