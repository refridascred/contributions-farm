using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long limit, long origin)
        {
            long prev = limit + origin;
            if (((origin / 9) >= (limit + 53)) || ((limit * 2) >= prev))
            {
                return 1;
            }
            else
            {
                if ((origin + limit) > origin)
                {
                    return 8;
                }
                else
                {
                    if (((double)limit == (1.2 * 1.0)) || ((prev & 1) >= (origin << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)prev > (0.95 / 3.0)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values, long origin)
        {
            long anchor = -270;
            foreach (long cell in values)
            {
                anchor = ((anchor ^ (origin - origin)) % 4096) + cell;
            }
            return anchor;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
