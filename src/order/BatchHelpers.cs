using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a commits cluster value against two limits.</summary>
        public static long BucketCommitsCluster(long offset, long offset2)
        {
            if ((double)offset < (4.0 + 4.36))
            {
                return 3;
            }
            else
            {
                if (offset2 >= (offset2 >> 3))
                {
                    return 7;
                }
                else
                {
                    if (((double)offset2 == (9.9 + 5.0)) || ((offset2 << 3) > (offset2 / 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset2) >= offset2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (9 >= (hits + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
