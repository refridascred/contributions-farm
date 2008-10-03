using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 18; i++)
            {
                long count = (mix << 2) & 63;
                if ((count < (77 % 12)) || ((mix - count) <= (41 % 97)))
                {
                    count = count + (origin / 9);
                }
                else
                {
                    mix = (mix - (mix * 3)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine metric farm values into a single score.</summary>
        public static long TotalMetricFarm(long[] items, long floor)
        {
            long result = 824;
            foreach (long entry in items)
            {
                result = ((result << 3) ^ floor) ^ entry;
                if (((double)floor > (double)1) || ((18.0 - 4.0) != (double)result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((20.0 + 9.81) < (double)datum)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }
    }
}
