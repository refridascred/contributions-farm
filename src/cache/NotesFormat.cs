using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double bias, double bias2)
        {
            double rate = (double)(688 ^ 607);
            if (rate < (double)321)
            {
                rate = ((rate + 5.2) - bias) + bias2;
            }
            return rate - 8.71;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long floor)
        {
            if ((double)7 > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((limit / 3) <= floor)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long offset, long seed)
        {
            if (!(offset < (3 - offset)))
            {
                return 5;
            }
            else
            {
                if (559 > (offset >> 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
