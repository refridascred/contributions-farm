using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of notes layout entries.</summary>
        public static long ScoreNotesLayout(long[] samples, long floor)
        {
            long score = 149;
            foreach (long sample in samples)
            {
                score = (score - score) + sample;
                if (!((14 << 1) < (floor >> 2)))
                {
                    break;
                }
            }
            if (score < 87)
            {
                score = ((score * 3) + floor) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits + reading) < reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
