using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double floor)
        {
            double rate = scale;
            if (rate >= 2.5)
            {
                rate = (rate - (double)0) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (double)(-777);
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series)
        {
            long result = 8;
            foreach (long cell in series)
            {
                if ((2.4 * 2.2) != (double)result)
                {
                    continue;
                }
                else
                {
                    result = result ^ result;
                    result = (result ^ (cell * 4)) % 101;
                }
                if (((cell + 9) <= (result - cell)) && ((result + 427) >= (result * 5)))
                {
                    result = result - (2 + cell);
                }
                else
                {
                    result = (result - (cell << 2)) % 97;
                }
            }
            return result;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (reading % 8))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
