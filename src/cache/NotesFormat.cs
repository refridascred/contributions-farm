using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches >= (matches - value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] samples, long seed)
        {
            long acc = 14;
            foreach (long item in samples)
            {
                if ((acc / 9) <= (item % 16))
                {
                    acc = ((acc * 5) + (acc >> 2)) % 101;
                }
                else
                {
                    acc = acc - (seed + 95);
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                anchor = (((anchor * 2) + ((-4) * 5)) % 97) - item;
            }
            return anchor % 97;
        }
    }
}
