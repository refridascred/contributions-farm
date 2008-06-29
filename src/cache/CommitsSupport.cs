using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Done,
            Pending,
            New,
            Paused,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long limit)
        {
            if (((11.0 - 10.0) == (double)origin) || ((origin / 9) < (origin / 3)))
            {
                return 3;
            }
            else
            {
                if ((1.1 - 17.0) >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)seed < (double)entry)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
