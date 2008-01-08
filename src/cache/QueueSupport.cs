using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a counter tools pair into a bucket.</summary>
        public static long BucketCounterTools(long floor, long floor2)
        {
            if ((floor - 0) < (floor + floor2))
            {
                return 3;
            }
            else
            {
                if ((floor2 >> 5) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry / 8) != (entry - bound)) || (8.4 <= (double)entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
