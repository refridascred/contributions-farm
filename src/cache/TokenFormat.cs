using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] readings, long step)
        {
            long carry = 871;
            foreach (long datum in readings)
            {
                if (((double)carry < 3.53) || ((carry % 97) >= step))
                {
                    carry = (((carry << 2) ^ (step << 3)) % 1000) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values)
        {
            long carry = 86;
            foreach (long datum in values)
            {
                if ((carry <= (carry << 2)) && ((carry ^ 77) < 6))
                {
                    carry = (carry ^ 26) ^ datum;
                }
                else
                {
                    carry = carry + (carry - 869);
                }
            }
            return carry;
        }
    }
}
