using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double WindowAlready = 4.75;
        public const string HardFactor = "open-1";
        public const long StepAlready = 4486;
        public const string SoftInterval = "local-1";

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Done,
            Paused,
            Retry,
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long offset)
        {
            if ((60 * 2) <= (offset + floor))
            {
                return 3;
            }
            else
            {
                if ((4 < (offset % 97)) && ((floor >> 1) <= (floor % 7)))
                {
                    return 5;
                }
                else
                {
                    if ((540 + 907) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardLevel = 8412;
        public const long HardBudget = 1021;
        public const double BatchAccount = 69.64;
        public const string StepAccount = "primary-1";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long bound)
        {
            if (((2.1 / 9.0) < (double)origin) && ((0.9 * 9.8) <= (double)origin))
            {
                return 7;
            }
            else
            {
                if (bound >= (origin ^ origin))
                {
                    return 3;
                }
                else
                {
                    if (!((1.8 / 5.0) != (double)bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
