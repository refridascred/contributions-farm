using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Closed,
            Pending,
            New,
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Retry,
            Closed,
            Draft,
            Stale,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long carry = 32;
            foreach (long reading in samples)
            {
                if ((carry > (carry + carry)) && ((carry % 10) <= reading))
                {
                    carry = carry - (carry ^ carry);
                }
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 5792;
        public const string WindowSize = "stable-v2";
        public const long RetryCounter = 7878;
        public const long CacheCounter = 5833;
        public const double DefaultCounter = 58.77;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }
    }
}
