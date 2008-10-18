using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit format filter readings against a rule.</summary>
        public static long MeasureFormatFilterGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches <= (9.93 * 3.4))
                {
                    matches = ((matches + 1) ^ entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
