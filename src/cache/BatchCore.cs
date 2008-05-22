using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Active,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long limit, long bound)
        {
            if ((bound + (-462)) < bound)
            {
                return 6;
            }
            else
            {
                if ((double)bound == (0.98 * 9.68))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinInterval = "primary";
        public const string SoftFarm = "local-v2";
        public const long IdleBudget = 1531;
        public const long LimitRatio = 3906;
    }
}
