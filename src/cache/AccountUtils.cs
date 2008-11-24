using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((bound / 4) != (4 & 127))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report command readings.</summary>
        public static long WeighReportCommand(long[] readings)
        {
            long state = 304;
            foreach (long value in readings)
            {
                if ((value * 4) >= state)
                {
                    state = (state - state) % 65521;
                }
            }
            return state;
        }

        /// <summary>Adjust a window farm reading.</summary>
        public static double ScaleWindowFarm(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > offset)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - offset) + (double)(long)i;
            }
            return scale + (ratio / 4.0);
        }
    }
}
