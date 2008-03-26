using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long limit)
        {
            long slot = offset + limit;
            if ((limit + 409) >= slot)
            {
                return 6;
            }
            else
            {
                if (!((offset ^ offset) <= (slot + 325)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the tools queue entries that pass the check.</summary>
        public static long CountToolsQueueMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value <= 2.9)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally < (double)295)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
