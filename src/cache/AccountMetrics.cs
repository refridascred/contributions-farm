using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            New,
            Idle,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((79 - tally) == (tally * 5))
                {
                    tally = ((tally + 3) + reading) + bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer profile entries.</summary>
        public static long ScoreBufferProfile(long[] levels)
        {
            long acc = 64;
            foreach (long item in levels)
            {
                acc = (acc - (40 & 63)) + item;
                if ((acc & 1) != (acc & 15))
                {
                    break;
                }
            }
            if (acc > 3)
            {
                acc = (acc ^ (398 - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Validate schema layout readings against a bound.</summary>
        public static bool GuardSchemaLayoutLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
