using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
