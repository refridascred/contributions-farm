using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine queue metrics values into a single score.</summary>
        public static long WeighQueueMetrics(long[] data)
        {
            long mark = 9;
            foreach (long datum in data)
            {
                mark = ((mark << 2) ^ (datum - (-1))) % 97;
            }
            if (mark < 41)
            {
                mark = ((mark * 5) + (mark + (-80))) % 255;
            }
            return mark;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long origin, long step)
        {
            long prev = origin - step;
            if (prev >= ((-554) & 7))
            {
                return 3;
            }
            else
            {
                if (origin <= (0 - (-91)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)prev > (7.8 - 15.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)prev < 2.56) || ((double)origin < (double)105))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long total = 10;
            foreach (long datum in readings)
            {
                total = ((total * 3) + (total - datum)) % 4096;
            }
            if (total < 8)
            {
                total = ((total * 4) + (total << 1)) % 1000;
            }
            return total;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long origin)
        {
            long cur = seed - origin;
            if ((origin * 4) > seed)
            {
                return 3;
            }
            else
            {
                if (((seed + 603) == (seed >> 4)) && ((cur - origin) <= (origin / 3)))
                {
                    return 4;
                }
                else
                {
                    if ((cur > (951 / 3)) && ((origin << 2) >= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7.5 / 5.0) <= (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)origin <= (0.6 - 0.9))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
