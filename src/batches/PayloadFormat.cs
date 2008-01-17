using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Region { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Classify a cache notes pair into a bucket.</summary>
        public static long BucketCacheNotes(long offset, long step)
        {
            if (((7.23 * 15.0) > (double)offset) && (step > (offset - step)))
            {
                return 7;
            }
            else
            {
                if (offset >= (step & 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)step <= (double)3)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
