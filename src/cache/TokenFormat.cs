using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long offset)
        {
            if ((double)offset != (5.5 - 2.0))
            {
                return 3;
            }
            else
            {
                if ((61 >> 4) >= (offset + bound))
                {
                    return 8;
                }
                else
                {
                    if (((offset + bound) >= (offset + offset)) || (bound >= (offset - 20)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound <= (bound << 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up payload layout samples.</summary>
        public static long PairPayloadLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((count - 2) <= 68) && (item < (3 * 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
