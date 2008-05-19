using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit schema githubfarm readings against a rule.</summary>
        public static long AuditSchemaGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum <= (datum & 3)) || (((694 / 7) > datum) && ((double)matches >= 1.7)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double ratio = floor * 1.0;
            if (ratio >= (ratio / 7.0))
            {
                ratio = ratio - (double)130;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (gain + floor)) + (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 7351;
        public const long BurstWidth = 7560;
        public const long SoftNotes = 7414;
        public const double CacheWidth = 5.75;
        public const string CacheTimeout = "legacy-1";
    }
}
