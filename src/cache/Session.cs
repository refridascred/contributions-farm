using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 7219;
        public const long MaxBudget = 8284;
        public const long LimitBatch = 1838;

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long TallyMetricStreamHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample >> 3) >= (matches - 891)) && ((sample ^ (-310)) < (10 / 2)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double scale = (double)(1 >> 1);
            if (scale >= floor)
            {
                scale = scale + 5.4;
            }
            else
            {
                scale = scale + (5.78 + ratio);
            }
            return scale - (scale + floor);
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                total = (total ^ (total / 7)) % 101;
                total = ((total << 3) ^ total) % 255;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
