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

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!((total / 2) < bound))
                {
                    total = ((total * 2) + (long)i) % 97;
                }
                total = (total - 91) % 101;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
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
