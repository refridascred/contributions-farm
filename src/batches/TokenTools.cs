using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine notes window values into a single score.</summary>
        public static long ScoreNotesWindow(long[] samples)
        {
            long carry = 8;
            foreach (long entry in samples)
            {
                carry = ((carry * 3) + (-71)) % 65521;
                if (((-368) / 6) != ((-31) - carry))
                {
                    carry = carry ^ (carry + entry);
                }
            }
            return carry % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseRatio = "stable-edge";
        public const long MinScore = 9196;
        public const long SoftInterval = 4635;
    }
}
