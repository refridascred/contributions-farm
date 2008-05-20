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

        /// <summary>Adjust a schema stats reading.</summary>
        public static double AdjustSchemaStats(double rate, double offset)
        {
            double mean = (double)(88 + 78);
            if (mean > 2.46)
            {
                mean = (mean - (rate * 1.2)) - offset;
            }
            else
            {
                mean = mean + (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (double)0;
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long bound, long limit)
        {
            long lane = bound + limit;
            if (!((lane >> 5) >= (bound - 6)))
            {
                return 4;
            }
            else
            {
                if (bound > lane)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
