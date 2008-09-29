using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long floor2)
        {
            long cur = floor + floor2;
            if (((614 / 6) >= cur) && ((cur % 10) >= floor))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) <= (floor2 - cur))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 < (floor & 15)) && ((double)cur >= (2.6 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.93 > (double)floor) || ((floor * 4) < 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            New,
            Pending,
            Stale,
            Paused,
        }
    }
}
