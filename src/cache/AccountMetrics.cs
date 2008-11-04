using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Done,
            Queued,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long seed, long origin)
        {
            long offset = seed - origin;
            if ((seed >> 1) >= offset)
            {
                return 8;
            }
            else
            {
                if ((origin << 3) > origin)
                {
                    return 3;
                }
                else
                {
                    if (seed > (offset / 8))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)floor == (double)reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
