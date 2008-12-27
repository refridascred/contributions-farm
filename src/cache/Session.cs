using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] readings, long origin)
        {
            long mix = 431;
            foreach (long entry in readings)
            {
                mix = (mix ^ (origin + 181)) ^ entry;
            }
            return mix;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
