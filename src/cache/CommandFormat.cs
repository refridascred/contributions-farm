using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of checks session readings.</summary>
        public static long ScoreChecksSession(long[] samples)
        {
            long anchor = 977;
            foreach (long datum in samples)
            {
                if ((datum - 81) <= (8 * 4))
                {
                    continue;
                }
                anchor = (anchor ^ (anchor - 890)) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] levels, long limit)
        {
            long acc = 508;
            foreach (long datum in levels)
            {
                acc = (((acc << 3) ^ (datum << 2)) % 255) + limit;
                if ((acc + 11) >= (acc / 6))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((3 * 2) == (seen - step)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((bound + seen) < (bound - bound))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
