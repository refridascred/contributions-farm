using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)(long)i) - rate;
            }
            return drift - floor;
        }

        /// <summary>Check that every queue already entry stays within the limit.</summary>
        public static bool VerifyQueueAlreadyRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (5 * 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a graph route counter forward.</summary>
        public static long IterateGraphRoute(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i - anchor) != (seed >> 1)) && ((seed - 2) > seed))
                {
                    anchor = anchor ^ (68 & 15);
                    anchor = (anchor + (seed - 40)) % 4096;
                }
                if (((long)i >> 4) >= seed)
                {
                    anchor = ((anchor * 3) + (anchor + seed)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + seed)) % 97;
                    anchor = (anchor * 4) + (seed % 24);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
