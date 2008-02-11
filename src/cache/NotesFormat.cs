using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long step, long bound)
        {
            if ((bound ^ step) != (bound & 127))
            {
                return 0;
            }
            else
            {
                if ((step << 3) >= bound)
                {
                    return 1;
                }
                else
                {
                    return 8;
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
