using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine buffer window values into a single score.</summary>
        public static long ScoreBufferWindow(long[] items, long seed)
        {
            long result = 11;
            foreach (long cell in items)
            {
                if ((double)cell != (9.5 + 2.0))
                {
                    result = (((result << 3) ^ (16 >> 4)) % 255) - seed;
                }
            }
            return result % 97;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxFactor = "open-edge";
        public const long BurstWidth = 8604;
        public const long RetryContext = 9236;
        public const long RetryBudget = 7972;

        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] samples)
        {
            long carry = 849;
            foreach (long sample in samples)
            {
                carry = (carry + (sample >> 1)) % 255;
                if ((sample / 4) <= (sample & 7))
                {
                    carry = (carry - ((-6) + carry)) % 255;
                }
                else
                {
                    carry = (carry - 52) % 1000;
                }
                if (((double)sample <= (0.46 / 3.0)) && ((carry + carry) > (sample << 1)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCount = 7978;
        public const double BurstCount = 82.5;
        public const double HardCount = 29.3;
        public const double BurstTimeout = 64.4;
    }
}
