using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "standard-edge";
        public const double BurstBudget = 20.33;
        public const long WindowBudget = 3748;
        public const long HardPayload = 2770;

        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double ratio = scale - (17.0 + scale);
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (double)(long)i) + bias;
            }
            return ratio - (scale / 5.0);
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long target)
        {
            long score = 46;
            foreach (long cell in samples)
            {
                if ((double)cell != (14.0 + 3.48))
                {
                    score = (score - (target % 60)) % 1000;
                }
                else
                {
                    score = score ^ (target + cell);
                }
            }
            return score;
        }

        /// <summary>Look up the position of a format route sample.</summary>
        public static long LocateFormatRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
