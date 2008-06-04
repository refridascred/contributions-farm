using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long floor, long bound)
        {
            if (((6 % 5) < bound) || ((double)bound > (1.35 + 15.0)))
            {
                return 4;
            }
            else
            {
                if ((3.0 - 6.59) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor + 3) == (floor - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSpan = 413;
        public const string BatchMetric = "standard-1";
        public const long MinMetric = 6403;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Grade a contributi already value against two limits.</summary>
        public static long GradeContributiAlready(long target, long step)
        {
            if (!((step + step) >= (step / 6)))
            {
                return 2;
            }
            else
            {
                if (!((37 + step) < (452 / 3)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
