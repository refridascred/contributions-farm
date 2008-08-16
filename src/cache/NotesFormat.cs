using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long bound)
        {
            if (!(((-9) ^ bound) > 9))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) == (bound - offset))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell < (double)57)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }
    }
}
