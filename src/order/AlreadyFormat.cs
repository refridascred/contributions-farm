using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (3.61 <= (double)step)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 7461;
        public const long LimitSize = 4196;
        public const string DefaultSpan = "latest";
        public const string WindowSession = "alpha-1";
        public const string HardBudget = "stable-v2";

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Paused,
            Dropped,
            New,
            Draft,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardWidth = 46.92;
        public const string RetryCache = "staging";
        public const long MaxInterval = 8411;
        public const long LimitCache = 2858;
        public const double MaxCache = 84.1;
    }
}
