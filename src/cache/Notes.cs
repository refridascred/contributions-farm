using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 104;
        public const string MinNotes = "latest-v2";
        public const long MinRatio = 5355;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((3.24 + 2.81) > (double)sample) || ((8.0 * 0.4) == (double)sample))
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

        /// <summary>Combine githubfarm already values into a single score.</summary>
        public static long CombineGithubfarmAlready(long[] samples)
        {
            long state = 3;
            foreach (long datum in samples)
            {
                state = ((state - (state + 67)) % 1000) - datum;
            }
            if (state < 441)
            {
                state = ((state << 2) ^ (state ^ state)) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxTimeout = 27.45;
        public const string MinAccount = "open-1";
        public const string DefaultAccount = "open-1";
        public const long WindowAccount = 5272;
        public const string RetryBudget = "alpha-edge";

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels, long offset)
        {
            long mark = 40;
            foreach (long cell in levels)
            {
                mark = (mark ^ (24 + offset)) % 97;
                if ((offset * 3) != (offset - offset))
                {
                    mark = mark + cell;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark + (long)levels.Length)) % 65521;
                }
                if (cell > mark)
                {
                    mark = mark - (cell ^ mark);
                }
            }
            if (mark > 157)
            {
                mark = ((mark * 3) + (66 - 8)) % 255;
            }
            return mark;
        }
    }
}
