using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate profile context samples.</summary>
        public static long TallyProfileContext(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                mark = (mark << 3) ^ (mark - mark);
                mark = ((mark << 3) ^ (floor - floor)) % 4096;
                if ((mark * 5) <= (item >> 2))
                {
                    mark = mark ^ (416 % 2);
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
            }
            if (mark < 9)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 > (bias2 / 4.0))
            {
                bias2 = bias2 + (bias - 16.0);
            }
            else
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - floor;
        }
    }
}
