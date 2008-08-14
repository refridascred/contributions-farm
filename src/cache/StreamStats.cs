using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstBudget = "local-v2";
        public const long DefaultFilter = 3386;
        public const string HardCount = "staging-edge";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((9 ^ matches) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
