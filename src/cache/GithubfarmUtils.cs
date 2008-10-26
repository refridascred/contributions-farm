using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many graph token samples are out of range.</summary>
        public static long AuditGraphTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + matches) <= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen < 0)
                {
                    seen = ((seen + 3) - reading) - step;
                }
            }
            return seen;
        }

        /// <summary>Roll a metric queue counter forward.</summary>
        public static long DeriveMetricQueue(long offset)
        {
            long result = offset;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
