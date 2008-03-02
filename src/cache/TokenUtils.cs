using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long floor)
        {
            long mark = 39;
            foreach (long reading in items)
            {
                if ((8.0 / 8.0) <= (double)mark)
                {
                    mark = ((mark + (mark ^ reading)) % 255) - floor;
                }
                if (mark <= (reading * 5))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
