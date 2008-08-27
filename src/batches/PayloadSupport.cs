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

        /// <summary>Look up the position of a checks window sample.</summary>
        public static long SeekChecksWindowIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
