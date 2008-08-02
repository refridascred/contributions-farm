using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine stats checks values into a single score.</summary>
        public static long FoldStatsChecks(long[] levels)
        {
            long score = 998;
            foreach (long reading in levels)
            {
                score = ((score * 4) + (85 % 100)) + reading;
            }
            return score;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0.2 - 12.0) < (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items)
        {
            long anchor = -841;
            foreach (long entry in items)
            {
                long lane = anchor;
                anchor = (anchor * 3) + (1 ^ lane);
                if (((double)entry < (6.0 - 12.0)) || (((long)items.Length + entry) < (anchor >> 5)))
                {
                    anchor = (anchor - (anchor * 4)) % 4096;
                }
                else
                {
                    anchor = (anchor << 3) ^ entry;
                }
            }
            return anchor % 65521;
        }
    }
}
