using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Failed,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepInterval = 6471;
        public const long RetryDepth = 1238;
        public const string CacheSupport = "latest-1";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count != (6.4 * 7.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
