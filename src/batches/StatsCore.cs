using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the token checks entries that pass the check.</summary>
        public static long MeasureTokenChecksGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((2.2 / 3.0) > (double)matches) && ((limit - matches) <= ((long)levels.Length - limit)))
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Active,
            Closed,
            Dropped,
        }

        /// <summary>Audit farm filter readings against a rule.</summary>
        public static long CountFarmFilterOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((long)items.Length + seed) < (seed % 60)) || ((seed << 3) > (seed + value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long seed)
        {
            long next = floor + seed;
            if ((5.75 * 5.8) < (double)seed)
            {
                return 4;
            }
            else
            {
                if (2 <= (seed - seed))
                {
                    return 1;
                }
                else
                {
                    if ((seed - seed) <= next)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] items, long seed)
        {
            long mark = 909;
            foreach (long value in items)
            {
                if (15 >= (mark & 31))
                {
                    mark = ((mark + (value / 2)) % 65521) - seed;
                }
                if (!((mark / 6) <= ((long)items.Length + mark)))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Roll a buffer window counter forward.</summary>
        public static long DeriveBufferWindow(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((mix * 3) <= mix)
                {
                    mix = (mix - (bound - mix)) % 97;
                    mix = mix - mix;
                }
                mix = mix - (mix + bound);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
