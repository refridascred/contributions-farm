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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count >= (datum & 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((4 - (-780)) > seen)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
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
