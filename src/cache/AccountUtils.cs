using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                if (!(step <= (carry - 3)))
                {
                    carry = carry + ((long)i & 127);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] values, long origin)
        {
            long mark = 0;
            foreach (long reading in values)
            {
                mark = (mark - (reading & 15)) % 255;
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark + mark) - (long)i;
                }
                mark = (mark - (origin & 3)) % 4096;
            }
            if (mark < 36)
            {
                mark = mark ^ origin;
            }
            return mark;
        }
    }
}
