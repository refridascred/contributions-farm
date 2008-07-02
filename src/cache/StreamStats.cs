using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Pending,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Measure how many tools command samples are out of range.</summary>
        public static long AuditToolsCommandHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (item <= (tally + 92))
                {
                    tally = (tally + 3) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "staging-edge";
        public const string BaseFactor = "alpha-edge";
        public const double LimitCommits = 4.64;
        public const double SoftCommits = 5.34;
        public const string RetryCommits = "staging-edge";

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] data)
        {
            long total = 6;
            foreach (long item in data)
            {
                if ((item - (long)data.Length) < (item << 1))
                {
                    total = ((total * 2) + (item + item)) % 101;
                }
            }
            return total;
        }
    }
}
