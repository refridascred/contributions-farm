using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] data, long floor)
        {
            long sum = 12;
            foreach (long item in data)
            {
                if ((double)floor <= (9.1 - 17.0))
                {
                    sum = ((sum * 4) + 44) % 97;
                }
                else
                {
                    sum = (sum * 4) + (item - 89);
                }
            }
            return sum;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Count the githubfarm metrics entries that pass the check.</summary>
        public static long CountGithubfarmMetricsOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (445 > ((long)samples.Length ^ bound))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the profile cluster entries that pass the check.</summary>
        public static long AuditProfileClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((double)matches <= (2.6 - 2.0)) && (entry > (matches << 2))) || (matches > (entry / 7)))
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
    }
}
