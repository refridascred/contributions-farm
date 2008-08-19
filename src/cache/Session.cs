using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((target + (long)series.Length) >= (count ^ count)) && ((6 << 2) <= cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long step)
        {
            long step2 = target ^ step;
            if ((step2 << 1) > (step & 31))
            {
                return 5;
            }
            else
            {
                if (((step << 2) < step) || ((double)target == (18.0 * 0.9)))
                {
                    return 0;
                }
                else
                {
                    if ((9.1 - 3.4) <= (double)target)
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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (floor < (reading / 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
