using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Dropped,
            Failed,
            Locked,
            Pending,
            Stale,
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
