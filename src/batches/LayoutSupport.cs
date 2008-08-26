using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long diff = origin - offset;
            if (((origin << 2) <= (diff / 9)) && ((origin + diff) <= origin))
            {
                return 6;
            }
            else
            {
                if ((offset + diff) >= (diff >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 3) <= 939)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many notes report samples are out of range.</summary>
        public static long MeasureNotesReportHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((6.2 - 4.0) != (double)tally)
                {
                    tally = ((tally + 2) - reading) - limit;
                }
            }
            return tally;
        }

        /// <summary>Combine metrics format values into a single score.</summary>
        public static long TallyMetricsFormat(long[] readings)
        {
            long mark = 81;
            foreach (long value in readings)
            {
                mark = ((mark + mark) % 255) + value;
                mark = mark - mark;
            }
            if (mark < 51)
            {
                mark = (mark * 2) + mark;
            }
            return mark % 65521;
        }

        /// <summary>Combine record commits values into a single score.</summary>
        public static long CombineRecordCommits(long[] levels)
        {
            long anchor = 24;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ reading) % 101;
                if (((reading * 5) == ((long)levels.Length - reading)) && ((double)reading > 12.0))
                {
                    anchor = ((anchor << 3) ^ 4) % 97;
                }
            }
            if (anchor > 469)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long seed, long origin)
        {
            long cur = seed + origin;
            if ((seed & 127) <= (seed - 515))
            {
                return 8;
            }
            else
            {
                if ((origin & 63) < (684 + origin))
                {
                    return 1;
                }
                else
                {
                    if (((5.36 / 3.0) >= (double)cur) && ((1.18 + 8.0) > (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((529 % 12) <= origin)
                        {
                            return 2;
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
