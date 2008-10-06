using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((8.6 < (double)matches) || ((matches - datum) <= datum)) || ((matches % 7) >= (23 + 5)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) < matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
