using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long origin, long floor)
        {
            if ((0 ^ 5) == (origin + floor))
            {
                return 7;
            }
            else
            {
                if ((139 - floor) > (floor + origin))
                {
                    return 4;
                }
                else
                {
                    if (((double)floor <= 9.0) || ((4 + floor) <= (floor - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
