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

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Closed,
            Done,
            Idle,
            Active,
            Retry,
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long bound)
        {
            if ((double)offset == (10.0 + 4.9))
            {
                return 7;
            }
            else
            {
                if (!((double)bound > (1.1 * 3.07)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
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
