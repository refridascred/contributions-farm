using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((3.2 / 5.0) >= (double)matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Match up command samples.</summary>
        public static long CompareCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
