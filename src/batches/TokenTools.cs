using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((tally <= (455 % 60)) && ((item & 31) != (item + tally))) || ((tally < (2 << 2)) && (18.0 < (double)item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit metrics account readings against a rule.</summary>
        public static long TallyMetricsAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) < (hits + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((5.7 - 1.5) > (17.0 + 12.0))
                {
                    matches = ((matches + 2) - value) - limit;
                }
            }
            return matches;
        }
    }
}
