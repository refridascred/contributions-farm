using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultTimeout = 3707;
        public const long BaseBudget = 7609;
        public const long LimitRoute = 4110;
        public const double HardScore = 7.69;
        public const string SoftCount = "legacy-1";

        /// <summary>Look up the position of a stream graph sample.</summary>
        public static long LookupStreamGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Done,
            Failed,
            New,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
