using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 6432;
        public const string DefaultLevel = "fallback";
        public const long RetryBudget = 5918;
        public const string IdleRatio = "stable-v2";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            New,
            Active,
            Retry,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long total = -948;
            foreach (long reading in samples)
            {
                total = (total * 3) + (reading + reading);
            }
            if (total > 613)
            {
                total = total - 32;
            }
            return total % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 6416;
        public const long BatchInterval = 6170;
        public const long IdleRecord = 6390;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Flag { get; set; } = "";
            public double Mode { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the record payload entries that pass the check.</summary>
        public static long AuditRecordPayloadHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((1.0 >= (double)offset) && ((double)tally > (5.75 * 6.8))) || ((tally % 12) > (offset % 24)))
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
