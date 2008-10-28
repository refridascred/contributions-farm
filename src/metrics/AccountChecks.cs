using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((edge + edge) >= origin)
            {
                return 0;
            }
            else
            {
                if (!(edge <= (origin - edge)))
                {
                    return 6;
                }
                else
                {
                    if (((double)edge > (double)origin2) && ((5.0 / 5.0) >= (double)edge))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series)
        {
            long mark = 59;
            foreach (long value in series)
            {
                if (6.12 > (double)mark)
                {
                    mark = ((mark << 2) ^ (302 % 24)) ^ value;
                }
                else
                {
                    mark = (mark << 2) ^ (mark & 7);
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the window channel series from a seed.</summary>
        public static long StepWindowChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
