using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches % 10) == ((long)readings.Length % 64)) || ((0 << 1) <= matches))
                {
                    matches = (matches + 2) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double scale = floor;
            return (scale + (double)836) + weight;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((5.96 / 4.0) < (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
