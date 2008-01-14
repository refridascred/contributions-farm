using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample & 1) >= matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((step % 60) > (step % 16)) || (((double)step < 4.3) && (datum <= (datum >> 1))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the metrics context entries that pass the check.</summary>
        public static long TallyMetricsContextGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry - 118) != (count >> 5)) && ((count - count) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
