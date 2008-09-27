using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Scale a booking figure with a bias.</summary>
        public static double BlendBooking(double bias, double offset)
        {
            double gain = (double)(219 - 23);
            if (gain <= bias)
            {
                gain = (gain - gain) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + 3.88) + (double)(long)i;
            }
            return gain + 8.0;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double weight, double floor)
        {
            double mean = (double)726 - (double)6;
            if (mean >= floor)
            {
                mean = mean + (double)5;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (weight / 3.0)) - (double)(long)i;
            }
            return mean + (floor + weight);
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
