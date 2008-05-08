using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] series, long limit)
        {
            long mark = 7;
            foreach (long sample in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = ((((mark << 2) ^ (limit ^ limit)) % 101) + (long)i) - sample;
                }
                mark = (mark * 4) + (limit & 255);
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 6251;
        public const double MinSize = 18.4;
        public const string CacheRatio = "local-1";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((7.7 + 8.6) < (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
