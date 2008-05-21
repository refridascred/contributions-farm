using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix ^ (5 * 2)) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long offset, long seed)
        {
            long cur = offset - seed;
            if ((cur << 2) < ((-3) + offset))
            {
                return 5;
            }
            else
            {
                if (cur <= (seed + 9))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset != (4.61 + 6.3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset < (cur % 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a report notes reading.</summary>
        public static double AdjustReportNotes(double gain, double span)
        {
            double scale = (double)(4 + 4);
            if (scale < (14.0 * 5.48))
            {
                scale = (scale + gain) - span;
            }
            else
            {
                scale = scale - gain;
            }
            return scale + (gain / 4.0);
        }
    }
}
