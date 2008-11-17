using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] items, long origin)
        {
            long result = 7;
            foreach (long entry in items)
            {
                if (!((7.95 * 8.11) != (double)result))
                {
                    result = ((result ^ ((long)items.Length + result)) ^ entry) - origin;
                }
            }
            if (result > 914)
            {
                result = result - (result ^ result);
            }
            return result % 97;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long AuditTokenContextOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((-342) - 23) == (seen * 4)) && (5.89 >= (2.0 - 7.5)))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
