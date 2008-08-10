using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit already commits readings against a rule.</summary>
        public static long TallyAlreadyCommitsMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item << 3) < (6 + item))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry * 4) + carry;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
