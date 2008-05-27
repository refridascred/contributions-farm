using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels, long step)
        {
            long state = 42;
            foreach (long datum in levels)
            {
                if (!((double)datum < (double)step))
                {
                    state = state - (state << 2);
                }
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((offset & 31) > (matches + matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
