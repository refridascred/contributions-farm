using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (5 < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits << 1) < (hits + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a metrics route figure with a bias.</summary>
        public static double BlendMetricsRoute(double gain, double span)
        {
            double bias = gain - (double)807;
            if (bias <= gain)
            {
                bias = bias + (span + 16.0);
            }
            else
            {
                bias = bias + 9.35;
            }
            return bias - 6.9;
        }
    }
}
