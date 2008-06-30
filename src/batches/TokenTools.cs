using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double load = (double)9 + bias;
            if (load >= (double)623)
            {
                load = load + 9.0;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)237) + (double)(long)i;
            }
            return load - (bias + gain);
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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long bound, long target)
        {
            if ((42 + target) >= (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((double)bound > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
