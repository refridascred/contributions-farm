using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long target, long target2)
        {
            long offset = target ^ target2;
            if ((9.15 * 7.1) < (double)target2)
            {
                return 0;
            }
            else
            {
                if ((target >> 2) < (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (((target - offset) >= (1 ^ target)) && ((offset + offset) <= (offset >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long carry = 5;
            foreach (long value in series)
            {
                if (((1 - carry) > (carry << 3)) && (carry >= (carry * 5)))
                {
                    carry = (((carry * 2) + carry) % 97) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
