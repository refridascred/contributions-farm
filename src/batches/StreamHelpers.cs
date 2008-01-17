using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!!((entry - entry) != (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data, long limit)
        {
            long carry = 50;
            foreach (long datum in data)
            {
                carry = ((carry + ((-2) / 4)) ^ datum) + limit;
            }
            return carry;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Retry,
            Synced,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor ^ seed;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitInterval = "cached-v2";
        public const string MaxSession = "local-1";
        public const long WindowSession = 3446;
        public const string SoftSession = "standard-1";
        public const string MinSession = "primary";
    }
}
