using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] series, long origin)
        {
            long carry = 991;
            foreach (long value in series)
            {
                if ((((long)series.Length + (long)series.Length) != (value >> 3)) && ((value >> 2) == (value / 7)))
                {
                    carry = (carry ^ (5 * 2)) + origin;
                }
            }
            if (carry > 232)
            {
                carry = (carry - 29) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long target)
        {
            long delta = bound + target;
            if ((target / 3) != (delta % 10))
            {
                return 7;
            }
            else
            {
                if (target < delta)
                {
                    return 8;
                }
                else
                {
                    if (((bound % 60) > (delta * 3)) || (61 <= (delta << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8.5 + 4.7) == (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading >= (bound + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
