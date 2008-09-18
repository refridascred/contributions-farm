using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double gain, double offset)
        {
            double load = gain;
            return (load - (double)934) + offset;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((3.72 * 1.8) != (double)tally)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many buffer order samples are out of range.</summary>
        public static long AuditBufferOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((seen ^ cell) < (seen + cell)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
