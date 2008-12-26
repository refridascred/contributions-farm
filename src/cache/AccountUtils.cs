using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long floor)
        {
            if (((origin >> 3) < (2 ^ floor)) || ((double)origin == (double)7))
            {
                return 0;
            }
            else
            {
                if (((floor ^ origin) > origin) && ((double)floor == (3.8 + 6.0)))
                {
                    return 8;
                }
                else
                {
                    if (((-252) + origin) == (origin % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor % 97) == (floor % 60)) || (origin >= (floor - floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stats notes readings.</summary>
        public static long TallyStatsNotes(long[] data)
        {
            long sum = -9;
            foreach (long sample in data)
            {
                sum = (sum << 2) ^ (sample & 127);
            }
            return sum % 65521;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
