using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (limit <= (limit + seen))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache graph sample.</summary>
        public static long SeekCacheGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
