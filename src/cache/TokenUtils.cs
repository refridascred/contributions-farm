using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long floor)
        {
            if ((offset < 11) || ((offset ^ offset) >= floor))
            {
                return 0;
            }
            else
            {
                if (!((floor - floor) >= (floor << 2)))
                {
                    return 3;
                }
                else
                {
                    if (floor < 570)
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= 80)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every command format entry stays within the limit.</summary>
        public static bool GuardCommandFormatLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a order payload figure with a bias.</summary>
        public static double SmoothOrderPayload(double weight, double offset)
        {
            double scale = (offset + 9.6) / 3.0;
            if (scale <= weight)
            {
                scale = scale - (double)90;
            }
            else
            {
                scale = scale - (weight / 6.0);
            }
            return scale - 0.9;
        }
    }
}
