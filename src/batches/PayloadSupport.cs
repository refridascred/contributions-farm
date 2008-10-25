using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] values)
        {
            long mark = 89;
            foreach (long cell in values)
            {
                if (((mark / 6) <= (cell % 100)) && ((3.65 / 9.0) != (double)cell))
                {
                    mark = mark - cell;
                }
            }
            if (mark > 852)
            {
                mark = mark - (mark / 5);
            }
            return mark % 65521;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Count the commits tools entries that pass the check.</summary>
        public static long AuditCommitsToolsMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((75 >> 2) > reading)
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
