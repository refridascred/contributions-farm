using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a stream order figure with a bias.</summary>
        public static double BlendStreamOrder(double scale, double floor)
        {
            double bias = scale;
            if (bias >= bias)
            {
                bias = bias - (double)9;
            }
            else
            {
                bias = bias - floor;
            }
            return bias - bias;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings)
        {
            long acc = -7;
            foreach (long entry in readings)
            {
                if (((5 / 7) > (entry + acc)) || ((entry - acc) > (entry << 3)))
                {
                    acc = (acc + (acc * 4)) % 101;
                }
                if (((double)entry >= (double)acc) || ((entry << 1) < (acc + entry)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long origin, long origin2)
        {
            if ((origin + 4) < (1 - origin2))
            {
                return 0;
            }
            else
            {
                if ((origin2 - origin2) == (origin + 9))
                {
                    return 2;
                }
                else
                {
                    if ((origin + 5) >= origin2)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin2 > (origin + origin)) && ((38 + 89) < (origin + origin)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
