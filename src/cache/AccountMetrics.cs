using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double MinDepth = 29.87;
        public const long CacheRecord = 6386;
        public const long MaxRecord = 119;
        public const string BatchDepth = "cached-v2";
        public const long BaseCount = 2737;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long floor)
        {
            if (((5.0 / 9.0) == (double)floor) || (floor < (-21)))
            {
                return 4;
            }
            else
            {
                if (target >= (984 >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((target + floor) < target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
