using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a record buffer pair into a bucket.</summary>
        public static long SortRecordBuffer(long floor, long seed)
        {
            if (((double)floor == (8.5 * 3.77)) && ((5.5 + 4.6) > (double)seed))
            {
                return 6;
            }
            else
            {
                if (seed <= (seed ^ seed))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
