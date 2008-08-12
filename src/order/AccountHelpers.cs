using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of cache order readings.</summary>
        public static long DigestCacheOrder(long[] data)
        {
            long mix = 82;
            foreach (long datum in data)
            {
                mix = (mix ^ 38) ^ datum;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many buffer tools samples are out of range.</summary>
        public static long MeasureBufferToolsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((seen / 7) < reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((limit % 24) >= 54) || ((double)seen != (9.4 * 6.15)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long floor, long limit)
        {
            long gap = floor - limit;
            if ((limit + gap) != (gap & 31))
            {
                return 1;
            }
            else
            {
                if (862 < (limit - 4))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (8.0 - 8.75))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading == (1.7 * 1.13))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
