using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double span)
        {
            double rate2 = 0.43 + 20.0;
            return (rate2 - (rate / 7.0)) + span;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((0 << 1) > (cell + (long)readings.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((result + origin) <= (origin - origin))
                {
                    result = (result - (28 + result)) % 101;
                }
                result = result ^ 3;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a report schema figure with a bias.</summary>
        public static double ProjectReportSchema(double scale, double span)
        {
            double scale2 = 1.69;
            if (scale2 <= (span - 6.0))
            {
                scale2 = scale2 - span;
            }
            else
            {
                scale2 = scale2 + (7.3 + span);
            }
            return scale2 + (span - scale);
        }
    }
}
