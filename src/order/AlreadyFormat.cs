using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long origin)
        {
            long mark = 465;
            foreach (long item in levels)
            {
                if ((5.0 + 19.0) > (double)origin)
                {
                    mark = ((mark + origin) % 4096) + item;
                }
            }
            if (mark < 648)
            {
                mark = mark + origin;
            }
            return mark;
        }

        /// <summary>Fold a list of layout metric readings.</summary>
        public static long DigestLayoutMetric(long[] series)
        {
            long total = 23;
            foreach (long datum in series)
            {
                if ((250 < (total + (long)series.Length)) || ((datum + total) > datum))
                {
                    total = (total + datum) % 1000;
                }
                else
                {
                    total = total + (datum & 255);
                }
            }
            return total;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long floor, long seed)
        {
            long next = floor - seed;
            if ((17.0 / 7.0) < (double)next)
            {
                return 4;
            }
            else
            {
                if (!(seed >= floor))
                {
                    return 0;
                }
                else
                {
                    if (((double)next != (5.0 * 7.2)) && ((double)next > (4.1 + 5.7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed <= (next << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
