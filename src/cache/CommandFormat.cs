using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long limit2)
        {
            if ((0 >> 5) < (limit & 63))
            {
                return 8;
            }
            else
            {
                if ((limit >> 5) == (limit2 - limit2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Queued,
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 4512;
        public const string MaxCluster = "stable-edge";
        public const long SoftRatio = 7435;
    }
}
