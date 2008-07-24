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

        /// <summary>Derive the next profile session value from a seed.</summary>
        public static long IterateProfileSession(long step)
        {
            long total = step;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 3) ^ (150 - total)) % 65521;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
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
