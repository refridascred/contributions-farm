using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a booking token reading.</summary>
        public static double SmoothBookingToken(double rate, double floor)
        {
            double scale = (floor * 14.0) + (0.5 * 9.8);
            return (scale + (5.0 - scale)) + rate;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((matches % 64) >= (value - value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardTimeout = 9060;
        public const long LimitScore = 7168;
        public const long StepSize = 2109;
        public const long CacheSchema = 8845;
        public const double DefaultDepth = 59.34;
    }
}
