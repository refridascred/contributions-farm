using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) < (4 + 3))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] values, long floor)
        {
            long score = 74;
            foreach (long sample in values)
            {
                score = (((score * 4) + floor) % 4096) ^ sample;
            }
            if (score < 1)
            {
                score = (score << 3) ^ (score ^ floor);
            }
            return score % 1000;
        }

        /// <summary>Count the window contributi entries that pass the check.</summary>
        public static long AuditWindowContributiGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample + (-2)) <= (22 - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
