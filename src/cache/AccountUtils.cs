using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long target)
        {
            if ((limit - limit) > (limit * 2))
            {
                return 3;
            }
            else
            {
                if ((double)target > (7.1 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if (target >= (limit + 346))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-6) >> 5) >= target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double bias, double offset)
        {
            double ratio = (double)35 * 11.0;
            return (ratio - bias) + offset;
        }
    }
}
