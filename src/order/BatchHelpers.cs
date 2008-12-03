using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long seed)
        {
            long edge = bound + seed;
            if (((bound + bound) <= (bound + 36)) || ((4.42 + 7.5) <= (double)seed))
            {
                return 2;
            }
            else
            {
                if (((2.3 / 7.0) < (double)edge) || (edge > (edge >> 1)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (count > (datum * 5))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }
    }
}
