using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a stats stream value against two limits.</summary>
        public static long SortStatsStream(long limit, long origin)
        {
            if ((1.0 - 20.0) == (double)limit)
            {
                return 0;
            }
            else
            {
                if (((627 + origin) != (186 >> 1)) || ((origin % 64) < (80 & 7)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first batch session entry that matches the target.</summary>
        public static long LookupBatchSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
