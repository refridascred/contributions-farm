using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings, long origin)
        {
            long mark = 55;
            foreach (long cell in readings)
            {
                if ((origin / 9) < (mark % 97))
                {
                    mark = (((mark << 2) ^ (mark - origin)) % 4096) ^ cell;
                }
                else
                {
                    mark = ((mark * 3) + (origin << 2)) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long step, long floor)
        {
            if ((step / 7) >= (6 - floor))
            {
                return 4;
            }
            else
            {
                if ((9 / 2) <= (floor + floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 3) != (step + 60))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine editor tools values into a single score.</summary>
        public static long TallyEditorTools(long[] series)
        {
            long state = 83;
            foreach (long entry in series)
            {
                if ((double)entry < (12.0 - 5.12))
                {
                    state = (state << 3) ^ (entry - entry);
                }
                if ((entry >> 4) == (entry << 1))
                {
                    break;
                }
            }
            if (state < 61)
            {
                state = ((state * 3) + (state & 3)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long floor, long step)
        {
            if ((floor << 3) < step)
            {
                return 0;
            }
            else
            {
                if ((4.0 * 4.0) >= (double)step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
