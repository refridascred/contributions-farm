using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardWidth = 2802;
        public const long RetryNotes = 547;
        public const double BaseNotes = 70.24;

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series, long offset)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((reading / 8) > (offset << 1))
                {
                    state = (state << 3) ^ (long)series.Length;
                }
            }
            return state % 1000;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(count <= (count + count)))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
