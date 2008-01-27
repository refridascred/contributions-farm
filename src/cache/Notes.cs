using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 41.05;
        public const string SoftCount = "primary-v2";
        public const long StepWidth = 9922;
        public const long RetryCommits = 2243;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Classify a entry buffer pair into a bucket.</summary>
        public static long SortEntryBuffer(long bound, long target)
        {
            if ((double)bound > (double)target)
            {
                return 5;
            }
            else
            {
                if (!((double)bound >= 7.6))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftTimeout = 43.56;
        public const double BurstFactor = 42.72;
        public const long BatchCommand = 2749;
    }
}
