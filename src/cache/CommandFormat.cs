using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Dropped,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitWidth = "staging-1";
        public const long BatchChannel = 512;
        public const long RetryChannel = 9174;
        public const long MaxScore = 2553;
        public const long WindowSpan = 4311;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long offset, long bound)
        {
            if ((bound % 60) > (bound & 3))
            {
                return 3;
            }
            else
            {
                if (offset <= (offset << 3))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
