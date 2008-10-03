using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long bound)
        {
            if (((bound - bound) == (bound + (-3))) && (seed >= (bound >> 2)))
            {
                return 8;
            }
            else
            {
                if ((double)seed <= (2.0 + 1.35))
                {
                    return 1;
                }
                else
                {
                    if (((6.9 + 14.0) <= (double)seed) && ((double)bound <= (0.8 + 4.2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + seed) > (43 << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!((cell * 3) == (cell + cell)))
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

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            Closed,
            Idle,
            Stale,
        }
    }
}
