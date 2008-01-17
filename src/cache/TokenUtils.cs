using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] series)
        {
            long mix = 9;
            foreach (long cell in series)
            {
                mix = mix ^ (cell * 3);
            }
            return mix;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long bound)
        {
            long total = 269;
            foreach (long datum in readings)
            {
                if ((double)datum > (8.85 - 6.78))
                {
                    total = (total * 4) + datum;
                    total = (total - (datum % 12)) % 97;
                }
                if ((datum + datum) >= total)
                {
                    total = (total - (datum + datum)) % 65521;
                }
                if ((datum << 2) < (total - bound))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long origin, long limit)
        {
            long edge = origin + limit;
            if (limit <= (origin % 64))
            {
                return 6;
            }
            else
            {
                if (((origin + edge) != (origin >> 2)) || ((7 + origin) <= (edge ^ origin)))
                {
                    return 3;
                }
                else
                {
                    if ((7.9 + 5.8) > (double)edge)
                    {
                        return 8;
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
