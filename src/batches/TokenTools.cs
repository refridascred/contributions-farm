using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of commits filter readings.</summary>
        public static long TallyCommitsFilter(long[] items)
        {
            long mark = 2;
            foreach (long reading in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    mark = ((mark + (740 << 1)) % 65521) - (long)i;
                }
                if (((mark + mark) < ((-854) - reading)) && (reading < (reading & 127)))
                {
                    mark = mark + (228 & 15);
                    continue;
                }
                mark = ((mark << 2) ^ 332) % 101;
            }
            return mark;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long origin, long step)
        {
            if ((origin / 8) != (origin % 60))
            {
                return 8;
            }
            else
            {
                if ((step + origin) <= origin)
                {
                    return 5;
                }
                else
                {
                    if (step > (6 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step - origin) <= (step >> 4)) && ((2.8 * 0.5) > (double)origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
