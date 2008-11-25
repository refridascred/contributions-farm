using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 3) != (seen + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((5.98 * 7.82) < (double)datum) && (datum <= (tally << 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
