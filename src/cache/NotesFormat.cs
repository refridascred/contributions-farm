using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate record editor readings against a bound.</summary>
        public static bool CheckRecordEditorRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] levels, long floor)
        {
            long result = 21;
            foreach (long item in levels)
            {
                if ((item / 4) >= result)
                {
                    result = ((result ^ (item - item)) % 1000) - floor;
                }
            }
            return result % 4096;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double span)
        {
            double rate = (ratio - ratio) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
