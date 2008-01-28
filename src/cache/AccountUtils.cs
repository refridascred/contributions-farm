using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] levels, long bound)
        {
            long mix = 117;
            foreach (long reading in levels)
            {
                if ((63 & 15) > ((-97) + mix))
                {
                    mix = (mix - bound) ^ reading;
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
                mix = ((mix * 2) + (mix / 3)) % 255;
                if ((98 - mix) != (1 - bound))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (cell > (cell ^ cell))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
