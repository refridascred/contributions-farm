using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many tools batches samples are out of range.</summary>
        public static long TallyToolsBatchesOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((seed / 9) < (seed + seed)) || (seed < (entry + entry)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count == (8.7 - 9.24))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Rank notes layout input into a small class.</summary>
        public static long BucketNotesLayout(long limit, long seed)
        {
            if ((limit % 64) == (seed - 19))
            {
                return 5;
            }
            else
            {
                if (((seed & 15) != (20 + seed)) && (3.2 > (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
