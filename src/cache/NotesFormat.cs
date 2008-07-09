using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double bias, double floor)
        {
            double bias2 = 3.0;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 + (bias + bias)) + (double)(long)i) + floor;
            }
            return bias2 + (bias / 6.0);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long bound)
        {
            long delta = limit + bound;
            if ((double)bound >= (2.0 + 2.42))
            {
                return 8;
            }
            else
            {
                if (!((bound - delta) != (bound / 7)))
                {
                    return 1;
                }
                else
                {
                    if (((bound * 3) > (delta & 63)) || ((double)delta <= (1.4 + 0.4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (4 < limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
