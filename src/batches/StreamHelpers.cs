using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 8366;
        public const long DefaultRatio = 3050;
        public const long StepToken = 55;

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstScore = "strict";
        public const long IdleAlready = 894;
        public const long RetryAlready = 7365;
        public const long MinTimeout = 6413;
        public const string MinAlready = "staging";

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long target)
        {
            long gap = offset - target;
            if ((double)target < (4.51 / 9.0))
            {
                return 4;
            }
            else
            {
                if (((double)gap < (9.0 + 5.56)) && ((gap - target) == (gap + target)))
                {
                    return 8;
                }
                else
                {
                    if ((double)gap != (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples)
        {
            long carry = 145;
            foreach (long value in samples)
            {
                carry = carry + (value % 5);
                if ((double)value > (4.0 * 1.8))
                {
                    break;
                }
            }
            if (carry < 54)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
