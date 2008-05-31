using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowTools = "stable-1";
        public const long HardTools = 4825;
        public const long HardSpan = 6166;
        public const double BaseCount = 59.6;
        public const long MinTools = 2191;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Stale,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((10 ^ tally) != (entry ^ (long)items.Length))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Region { get; set; }
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((-6) - target) > (count & 1))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }
    }
}
