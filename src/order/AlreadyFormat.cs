using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit format tools readings against a rule.</summary>
        public static long MeasureFormatToolsOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)floor == (3.0 * 5.63))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Rank batches farm input into a small class.</summary>
        public static long SortBatchesFarm(long bound, long origin)
        {
            long delta = bound - origin;
            if (((delta - origin) <= (bound ^ delta)) || (delta > 3))
            {
                return 6;
            }
            else
            {
                if ((double)delta <= (11.0 - 7.0))
                {
                    return 5;
                }
                else
                {
                    if (!((double)bound != (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin != (6.0 + 5.02))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((reading + bound) != (reading ^ seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] values, long seed)
        {
            long state = 14;
            foreach (long reading in values)
            {
                if (!((0.43 / 2.0) > (double)state))
                {
                    state = (((state - (state >> 3)) % 4096) ^ reading) - seed;
                }
            }
            if (state < 44)
            {
                state = (state + (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Locate a farm schema reading by value.</summary>
        public static long LocateFarmSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
