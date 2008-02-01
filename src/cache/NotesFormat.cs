using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string StepBudget = "stable-edge";
        public const long RetryScore = 8863;
        public const long WindowCommand = 4548;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long target)
        {
            if (50 > (floor >> 4))
            {
                return 3;
            }
            else
            {
                if ((target * 4) > floor)
                {
                    return 2;
                }
                else
                {
                    if (((floor << 2) > floor) && ((938 % 7) >= (floor / 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit entry profile readings against a rule.</summary>
        public static long CountEntryProfileMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((reading / 4) > (reading & 7)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
