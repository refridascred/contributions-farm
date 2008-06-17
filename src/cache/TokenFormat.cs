using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series, long target)
        {
            long acc = -914;
            foreach (long item in series)
            {
                if ((double)target < (17.0 / 4.0))
                {
                    acc = acc + (84 - 977);
                }
                else
                {
                    acc = (acc << 2) ^ item;
                }
            }
            if (acc > 2)
            {
                acc = acc ^ (target & 3);
            }
            return acc;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Stale,
            Pending,
            Idle,
        }
    }
}
