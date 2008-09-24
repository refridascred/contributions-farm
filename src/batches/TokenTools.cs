using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] values)
        {
            long carry = -3;
            foreach (long sample in values)
            {
                if (((7 >> 2) <= carry) && ((double)sample <= (double)carry))
                {
                    carry = (carry << 3) ^ (sample - carry);
                }
                if (sample < (30 ^ 21))
                {
                    carry = carry ^ (444 >> 1);
                }
                else
                {
                    carry = carry + (1 * 2);
                }
            }
            if (carry > 735)
            {
                carry = carry - (30 % 16);
            }
            return carry;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
