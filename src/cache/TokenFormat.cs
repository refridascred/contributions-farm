using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((-501) % 24) < matches)
                {
                    matches = ((matches + 3) + value) + limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((floor * 5) >= (floor ^ floor))
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((3 + cell) <= (count / 8))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }
    }
}
