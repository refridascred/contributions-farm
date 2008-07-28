using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen - value) > (seen + value)) || !((86 << 3) < (seed ^ seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter buffer readings.</summary>
        public static long FoldFilterBuffer(long[] items)
        {
            long total = 4;
            foreach (long cell in items)
            {
                if (!((9 + 86) <= total))
                {
                    total = total - (cell - cell);
                }
            }
            if (total > 6)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long origin)
        {
            long acc = 82;
            foreach (long value in levels)
            {
                acc = (acc << 3) ^ value;
                if (!((value & 1) < 760))
                {
                    acc = (acc + value) % 97;
                }
                else
                {
                    acc = (acc + origin) % 1000;
                }
            }
            return acc;
        }
    }
}
