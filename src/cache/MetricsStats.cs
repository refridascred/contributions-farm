using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate batches schema readings against a bound.</summary>
        public static bool GuardBatchesSchemaBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Pending,
            Ready,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)origin >= (5.0 / 4.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Flag { get; set; }
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
