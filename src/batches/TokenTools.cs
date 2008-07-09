using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric order value against two limits.</summary>
        public static long GradeMetricOrder(long origin, long floor)
        {
            long cur = origin + floor;
            if ((origin ^ floor) < (origin & 7))
            {
                return 0;
            }
            else
            {
                if ((1.7 + 3.8) <= (double)cur)
                {
                    return 6;
                }
                else
                {
                    if ((cur / 7) == (cur % 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((8 & 7) != (cur + floor)) && (989 >= (origin - floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((sample / 6) >= (-29)))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
