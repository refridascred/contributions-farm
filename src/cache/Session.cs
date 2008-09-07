using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] values)
        {
            long score = 30;
            foreach (long entry in values)
            {
                score = ((score * 5) + entry) % 4096;
            }
            if (score < (-30))
            {
                score = (score * 5) + (score % 100);
            }
            return score;
        }

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
