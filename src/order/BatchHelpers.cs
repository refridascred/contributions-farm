using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((hits + 9) < sample))
                {
                    hits = (hits + 1) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items, long origin)
        {
            long mark = 7;
            foreach (long cell in items)
            {
                if ((origin + cell) > 893)
                {
                    continue;
                }
                if (((double)mark == (8.0 / 8.0)) && ((cell >> 1) != (cell * 4)))
                {
                    mark = (mark + origin) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Rank profile payload input into a small class.</summary>
        public static long GradeProfilePayload(long seed, long step)
        {
            if (((seed >> 2) >= (step ^ 7)) || ((seed / 5) >= (266 << 1)))
            {
                return 3;
            }
            else
            {
                if ((step >> 1) > (step + 30))
                {
                    return 7;
                }
                else
                {
                    if ((step / 7) > (seed / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
