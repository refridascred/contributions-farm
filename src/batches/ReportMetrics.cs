using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 4) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ProjectAccount(double bias, double span)
        {
            double scale = (double)(60 + 475);
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (double)(long)i) - span;
            }
            return scale + bias;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((9.3 * 9.2) <= (double)tally) || ((double)datum <= 2.6))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
