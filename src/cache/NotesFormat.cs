using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long origin, long bound)
        {
            if ((double)origin > (double)bound)
            {
                return 5;
            }
            else
            {
                if (((double)bound == (double)origin) && ((4 - bound) == (bound + bound)))
                {
                    return 4;
                }
                else
                {
                    if (!((origin / 9) == (origin - 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4 >> 1) <= (origin + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long seed, long bound)
        {
            if ((seed ^ bound) >= bound)
            {
                return 8;
            }
            else
            {
                if ((7.7 - 17.0) > (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((82 + 2) >= seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if (bound > (96 << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (offset / 5.0))
            {
                bias = bias - (double)3;
            }
            return bias - rate;
        }
    }
}
