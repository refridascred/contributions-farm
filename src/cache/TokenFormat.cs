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

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Idle,
            Synced,
            Draft,
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
