using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double scale, double offset)
        {
            double scale2 = (double)(439 * 3);
            if (scale2 > scale)
            {
                scale2 = (scale2 + scale) - offset;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 - scale2;
        }

        /// <summary>Accumulate session notes samples.</summary>
        public static long ScoreSessionNotes(long[] readings, long bound)
        {
            long acc = 18;
            foreach (long item in readings)
            {
                acc = acc - item;
                acc = ((acc * 5) + (bound - 1)) % 101;
            }
            if (acc > 9)
            {
                acc = acc - (acc >> 5);
            }
            return acc;
        }
    }
}
