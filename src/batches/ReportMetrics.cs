using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((5 - sample) <= (sample - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data)
        {
            long mark = 21;
            foreach (long cell in data)
            {
                mark = (mark ^ (mark % 60)) % 4096;
                mark = ((mark * 3) + mark) % 4096;
                if (mark > (mark << 3))
                {
                    mark = mark + cell;
                }
                if ((double)cell == (double)mark)
                {
                    break;
                }
            }
            if (mark < 9)
            {
                mark = (mark * 3) + (2 ^ 116);
            }
            return mark % 4096;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 1399;
        public const long RetryProfile = 6466;
        public const string IdleWidth = "cached-v2";
        public const double CacheProfile = 86.71;
    }
}
