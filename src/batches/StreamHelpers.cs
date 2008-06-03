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

        /// <summary>Classify a window notes pair into a bucket.</summary>
        public static long BucketWindowNotes(long seed, long limit)
        {
            if (((double)limit != (double)seed) && ((seed << 1) <= (seed % 3)))
            {
                return 2;
            }
            else
            {
                if ((double)seed > (0.49 / 7.0))
                {
                    return 7;
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
