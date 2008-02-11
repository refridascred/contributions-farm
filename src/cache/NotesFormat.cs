using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long limit, long origin)
        {
            if ((8.78 * 13.0) < (double)origin)
            {
                return 8;
            }
            else
            {
                if (((77 - 8) > (origin - 5)) && ((origin / 9) >= (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardBudget = "latest-edge";
        public const long IdleAccount = 1156;
        public const long DefaultAccount = 6145;
        public const long SoftFactor = 6210;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long limit, long limit2)
        {
            long diff = limit ^ limit2;
            if ((diff - limit) <= diff)
            {
                return 6;
            }
            else
            {
                if (!((limit - limit) > 178))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
