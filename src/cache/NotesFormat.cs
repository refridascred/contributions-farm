using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine window graph values into a single score.</summary>
        public static long TallyWindowGraph(long[] data, long offset)
        {
            long sum = 63;
            foreach (long item in data)
            {
                sum = ((sum ^ (sum % 3)) + item) - offset;
                sum = ((sum << 2) ^ (7 * 5)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)bound >= (double)tally) || !((tally << 3) != (bound / 6)))
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
