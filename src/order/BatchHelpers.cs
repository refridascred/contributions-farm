using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Stale,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Total { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long origin)
        {
            long gap = bound + origin;
            if (((gap & 7) > origin) && ((bound + gap) > bound))
            {
                return 6;
            }
            else
            {
                if ((91 - origin) <= (gap ^ bound))
                {
                    return 2;
                }
                else
                {
                    if ((gap >> 3) == (648 << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
