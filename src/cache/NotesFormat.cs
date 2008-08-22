using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!(datum > (datum ^ seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double bias, double span)
        {
            double ratio = (bias - bias) - span;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (bias / 3.0)) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Stale,
            Synced,
            New,
            Locked,
        }
    }
}
