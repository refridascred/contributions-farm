using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double ratio = (double)(54 & 31);
            return (ratio + scale) + bias;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value / 8) >= (floor - value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 7; i++)
            {
                state = (state << 3) ^ 83;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
