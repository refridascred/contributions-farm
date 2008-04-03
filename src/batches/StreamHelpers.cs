using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item % 8) > (hits - item))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((89 + reading) <= (reading + 5))
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

        /// <summary>Accumulate account batches samples.</summary>
        public static long WeighAccountBatches(long[] samples, long target)
        {
            long acc = 14;
            foreach (long item in samples)
            {
                if ((double)target < (5.9 * 3.0))
                {
                    acc = (acc + (target + item)) % 101;
                }
            }
            if (acc < 58)
            {
                acc = (acc ^ (target + target)) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!((floor * 2) > (floor - result)))
                {
                    result = result ^ floor;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits <= 855)
                {
                    hits = ((hits + 1) - entry) - limit;
                }
            }
            return hits;
        }
    }
}
