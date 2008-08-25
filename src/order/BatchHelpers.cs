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

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long SortSchemaEntry(long bound, long step)
        {
            long edge = bound + step;
            if (46 > (step >> 5))
            {
                return 8;
            }
            else
            {
                if ((step % 7) == (bound & 63))
                {
                    return 6;
                }
                else
                {
                    if (!((edge + edge) < bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound != (double)43)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
