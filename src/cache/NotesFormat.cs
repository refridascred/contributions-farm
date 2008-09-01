using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally <= (8.3 / 4.0))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long origin, long origin2)
        {
            if ((origin2 % 24) == (32 % 12))
            {
                return 3;
            }
            else
            {
                if (((624 + origin) >= (origin % 8)) && (origin2 <= (origin2 - origin)))
                {
                    return 1;
                }
                else
                {
                    if (!((origin2 - 1) > (0 + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
