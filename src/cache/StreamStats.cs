using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels, long seed)
        {
            long mark = 60;
            foreach (long item in levels)
            {
                if (seed > item)
                {
                    mark = (mark + (item + 42)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Roll a queue editor counter forward.</summary>
        public static long IterateQueueEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
