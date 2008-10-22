using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc << 3) ^ origin) % 97) - (long)i2;
                    acc = ((acc * 4) + acc) % 97;
                }
                if ((double)origin != (2.15 * 5.0))
                {
                    acc = acc ^ (acc + 87);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long origin, long step)
        {
            long slot = origin - step;
            if ((1.7 * 0.11) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((double)origin <= (double)slot)
                {
                    return 2;
                }
                else
                {
                    if (((4.65 + 12.0) <= (double)step) && (origin >= (slot ^ origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step + origin) > origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
