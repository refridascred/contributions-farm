using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowSize = 9067;
        public const long SoftTimeout = 3732;
        public const long MinAccount = 5025;
        public const string BaseBudget = "legacy-1";

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstRatio = "latest-edge";
        public const long BurstSize = 1638;
        public const long MinTimeout = 3075;
        public const string RetryAlready = "strict";
        public const long WindowDepth = 1537;

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long origin)
        {
            if ((origin - 5) == (718 ^ origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin >= (7.57 + 10.0)) || ((6 & 31) == (floor + floor)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (5.0 - 7.1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
            public double Size { get; set; }
        }
    }
}
