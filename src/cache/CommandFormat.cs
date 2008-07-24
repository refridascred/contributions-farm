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

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
