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

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                if (result >= (result & 7))
                {
                    result = result + (result % 64);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
