using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long bound, long limit)
        {
            if ((bound * 2) <= (limit / 2))
            {
                return 7;
            }
            else
            {
                if ((bound >> 2) != (limit % 2))
                {
                    return 1;
                }
                else
                {
                    if (((limit + limit) < 643) && ((double)limit <= (5.6 + 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + limit) == (bound & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheSpan = 5147;
        public const string WindowFilter = "primary-v2";
        public const long HardLevel = 9703;
    }
}
