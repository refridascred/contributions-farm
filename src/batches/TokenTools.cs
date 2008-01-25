using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long bound)
        {
            long diff = floor + bound;
            if (((floor + floor) == (diff - 27)) && ((8 >> 5) < (bound << 2)))
            {
                return 4;
            }
            else
            {
                if (((double)bound != (6.7 * 1.43)) || ((9.0 + 6.9) > (double)bound))
                {
                    return 8;
                }
                else
                {
                    if (floor > (diff & 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((diff % 3) != (bound << 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel route entries that pass the check.</summary>
        public static long AuditChannelRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!!((-284) > sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] data)
        {
            long result = 553;
            foreach (long item in data)
            {
                if (result >= (72 * 3))
                {
                    result = (result - (item ^ item)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (item ^ item)) % 65521;
                }
            }
            return result;
        }
    }
}
