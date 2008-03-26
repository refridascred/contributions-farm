using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 7) < hits)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                mark = (mark + reading) % 1000;
            }
            if (mark > 13)
            {
                mark = ((mark << 3) ^ (long)data.Length) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long origin, long offset)
        {
            if ((((-5) + offset) != (offset - 403)) || ((-2) >= offset))
            {
                return 4;
            }
            else
            {
                if ((double)origin < (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (((offset ^ 59) >= (origin * 5)) && ((double)origin < (13.0 - 8.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (1.0 <= (double)offset)
                        {
                            return 0;
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
}
