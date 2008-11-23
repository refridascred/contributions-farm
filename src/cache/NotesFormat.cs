using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches >> 3) < floor) || ((matches ^ floor) != (81 * 3)))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] levels, long bound)
        {
            long result = 963;
            foreach (long value in levels)
            {
                if ((0 - (long)levels.Length) != (bound & 255))
                {
                    result = (result - 9) ^ value;
                }
                else
                {
                    result = (result * 5) + (result / 5);
                }
            }
            if (result < 4)
            {
                result = ((result * 5) + (result >> 4)) % 97;
            }
            return result;
        }
    }
}
