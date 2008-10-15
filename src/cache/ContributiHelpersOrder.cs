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

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
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
