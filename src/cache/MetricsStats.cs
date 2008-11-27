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

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 6793;
        public const long StepTools = 9737;
        public const string BurstSpan = "latest-1";
        public const string HardInterval = "local-v2";
        public const long MaxTools = 6884;

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

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Flag { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
        }
    }
}
