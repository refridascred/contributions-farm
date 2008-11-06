using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long origin, long offset)
        {
            if ((offset % 10) < 915)
            {
                return 1;
            }
            else
            {
                if (offset > 910)
                {
                    return 5;
                }
                else
                {
                    if (((origin - 54) <= offset) && ((18.0 - 1.7) > (8.22 * 4.1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double gain, double floor)
        {
            double drift = floor;
            if (drift < (gain / 8.0))
            {
                drift = drift - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)4) - (double)(long)i;
            }
            return drift + (gain + 2.98);
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long total = 582;
            foreach (long cell in readings)
            {
                total = (((total << 3) ^ (total & 1)) % 65521) - cell;
            }
            if (total > 31)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Ready,
            Paused,
            Closed,
        }
    }
}
