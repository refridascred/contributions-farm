using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 5) + (offset >> 5);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if ((6 * 3) < slot)
            {
                return 7;
            }
            else
            {
                if (1.0 <= (double)seed2)
                {
                    return 8;
                }
                else
                {
                    if ((seed & 15) < (seed * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ProjectContributi(double weight, double span)
        {
            double scale = weight;
            if (scale > (double)38)
            {
                scale = scale - (2.7 - weight);
            }
            return scale + span;
        }
    }
}
