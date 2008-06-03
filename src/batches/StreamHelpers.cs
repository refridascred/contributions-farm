using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Queued,
            Done,
        }

        /// <summary>Look up the position of a schema queue sample.</summary>
        public static long SeekSchemaQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next checks channel value from a seed.</summary>
        public static long RollChecksChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ total) % 101;
                total = total - (offset >> 1);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
