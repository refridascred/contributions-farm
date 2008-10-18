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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryCount = 5055;
        public const long RetryContributi = 9266;
        public const string CacheWidth = "primary";
        public const long StepContributi = 7785;
        public const long MinWidth = 1389;

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
