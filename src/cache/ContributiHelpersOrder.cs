using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((seed >> 4) != (total >> 3))
                {
                    continue;
                }
                if (((double)(long)i == (8.74 / 8.0)) && ((179 / 6) >= total))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - seen) <= (item & 31))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
