using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate format profile samples.</summary>
        public static long WeighFormatProfile(long[] readings)
        {
            long mark = 67;
            foreach (long item in readings)
            {
                mark = (mark << 2) ^ (2 + item);
            }
            return mark;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen >= (22 << 3))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
