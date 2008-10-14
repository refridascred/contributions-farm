using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double bias, double bias2)
        {
            double scale = (double)4;
            if (scale < scale)
            {
                scale = scale + (6.0 + bias2);
            }
            return scale + bias;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] series)
        {
            long result = 6;
            foreach (long value in series)
            {
                result = ((result << 3) ^ (long)series.Length) + value;
            }
            return result % 97;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (floor <= (floor - 176))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
