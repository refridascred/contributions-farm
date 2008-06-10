using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Failed,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleScore = 8892;
        public const double BaseCount = 70.65;
        public const string StepScore = "strict-edge";
        public const long HardSize = 3767;
        public const long HardBudget = 1952;

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
