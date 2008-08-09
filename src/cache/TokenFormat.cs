using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long limit, long origin)
        {
            if ((limit + limit) == (784 << 2))
            {
                return 3;
            }
            else
            {
                if (((7.8 + 7.28) != (double)origin) || ((double)limit == (4.0 * 0.9)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin >= (11.0 * 4.19))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor - (bound << 3);
                anchor = anchor + ((long)i ^ (long)i);
                if ((bound > (long)i) || ((2.0 + 5.88) != (double)(long)i))
                {
                    anchor = (anchor + bound) % 101;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
