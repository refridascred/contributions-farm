using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many farm payload samples are out of range.</summary>
        public static long CountFarmPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((hits + 9) == (hits / 7)) || ((double)hits < (9.0 + 1.63))) && (2 <= (hits >> 5)))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }

        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double scale = (floor - floor) - floor;
            return (scale - (double)82) + rate;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                total = (total << 3) ^ 45;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
