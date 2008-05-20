using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "stable";
        public const double StepSize = 37.85;
        public const long MaxWindow = 824;
        public const string BaseWindow = "fallback-v2";

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double gain, double bias)
        {
            double gain2 = (bias * 3.7) / 4.0;
            if (gain2 >= (double)9)
            {
                gain2 = (gain2 - bias) + gain;
            }
            return gain2 - bias;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i + seed) > seed)
                {
                    score = ((score * 2) + (3 * 4)) % 101;
                    break;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a counter notes sample.</summary>
        public static long FindCounterNotesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
