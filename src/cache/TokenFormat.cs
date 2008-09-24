using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally & 63) == (datum + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                double weight = (double)state / 3.0;
                if ((weight / 5.0) >= weight)
                {
                    state = (state + (36 >> 1)) % 101;
                    state = (state + ((long)i / 7)) % 65521;
                }
                else
                {
                    weight = weight - weight;
                }
                weight = weight + (double)state;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double weight, double floor)
        {
            double load = (double)(5 - 67);
            if (load <= (double)675)
            {
                load = (load + weight) - floor;
            }
            return load + 19.0;
        }
    }
}
