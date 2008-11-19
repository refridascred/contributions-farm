using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Idle,
            Active,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading - origin) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank counter buffer input into a small class.</summary>
        public static long SortCounterBuffer(long seed, long floor)
        {
            long edge = seed + floor;
            if (((seed - 682) < (seed - floor)) && ((20.0 / 6.0) >= (double)seed))
            {
                return 1;
            }
            else
            {
                if ((0.9 * 0.82) < (double)seed)
                {
                    return 2;
                }
                else
                {
                    if (!((edge + seed) != (79 - floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (1.39 >= (double)floor)
                        {
                            return 4;
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
}
