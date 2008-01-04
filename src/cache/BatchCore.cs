using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen >= 5) && !(seen < (109 ^ seen)))
                {
                    seen = ((seen + 1) - sample) - floor;
                }
            }
            return seen;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (!(72 < (floor - 586)))
            {
                return 7;
            }
            else
            {
                if ((451 + (-88)) < (231 - origin))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
