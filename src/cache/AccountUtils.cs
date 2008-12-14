using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long floor2)
        {
            if ((floor2 + floor2) > (floor * 2))
            {
                return 2;
            }
            else
            {
                if (((-67) + floor) <= floor)
                {
                    return 7;
                }
                else
                {
                    if (((17.0 - 3.0) != (double)floor) && ((3 >> 3) <= floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor == (double)floor2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchTimeout = 7822;
        public const string LimitDepth = "fallback";
        public const string SoftEditor = "primary";
        public const long HardCount = 2434;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
