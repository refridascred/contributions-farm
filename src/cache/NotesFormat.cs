using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data)
        {
            long state = 49;
            foreach (long item in data)
            {
                state = ((state + (state & 3)) % 255) ^ item;
            }
            if (state > (-510))
            {
                state = (state * 4) + (state * 4);
            }
            return state % 1000;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((2 + step) > (step << 1))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }
    }
}
