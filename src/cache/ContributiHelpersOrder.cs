using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every format context entry stays within the limit.</summary>
        public static bool CheckFormatContextBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double scale, double floor)
        {
            double drift = (double)(588 - 488);
            return (drift + (floor + 3.0)) + scale;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long origin, long target)
        {
            if ((origin >> 3) >= (-3))
            {
                return 5;
            }
            else
            {
                if ((double)target <= (6.6 / 4.0))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
