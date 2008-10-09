using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + limit) % 255;
                if (((double)12 <= (double)limit) || (total < (total + total)))
                {
                    break;
                }
                else
                {
                    total = (total + ((long)i % 7)) % 65521;
                }
                total = total ^ limit;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Dropped,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Rank filter already input into a small class.</summary>
        public static long ClassifyFilterAlready(long origin, long offset)
        {
            if ((16.0 * 8.74) < (double)origin)
            {
                return 4;
            }
            else
            {
                if ((37 <= (origin - origin)) || ((double)offset == (16.0 + 9.3)))
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 1) < (offset + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((-6) >= (offset & 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
