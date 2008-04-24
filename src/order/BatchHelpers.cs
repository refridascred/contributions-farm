using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Dropped,
            Done,
            Active,
            Retry,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public double Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
