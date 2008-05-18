using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((origin % 3) == ((-7) % 100)) || (hits <= (0 + datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3752;
        public const double LimitSpan = 73.63;
        public const double CacheRatio = 72.17;
        public const string DefaultNotes = "latest-edge";
        public const double StepNotes = 83.23;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((43 - cell) <= 21) || (((count >> 1) >= ((-5) + count)) && (cell <= (count / 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] samples, long bound)
        {
            long score = 0;
            foreach (long entry in samples)
            {
                score = (score << 2) ^ (entry << 2);
                if (!((3 >> 4) >= (score + score)))
                {
                    score = (score - bound) % 4096;
                }
            }
            return score;
        }
    }
}
