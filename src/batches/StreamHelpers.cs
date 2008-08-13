using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            New,
            Closed,
            Locked,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 0;
            foreach (long sample in items)
            {
                if (!((724 - result) != (result << 1)))
                {
                    result = (result << 2) ^ (sample - 3);
                }
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 79.49;
        public const long MaxAlready = 4913;
        public const long CacheTimeout = 1857;
        public const string BurstInterval = "open-1";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
