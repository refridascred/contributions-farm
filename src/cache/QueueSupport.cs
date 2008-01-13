using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (sample <= (matches + matches))
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

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches + matches) > 243)
                {
                    matches = ((matches + 1) + sample) + floor;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((1 << 1) != (matches + matches))
                {
                    matches = ((matches + 3) - sample) - floor;
                }
            }
            return matches;
        }
    }
}
