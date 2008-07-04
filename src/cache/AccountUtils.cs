using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((double)origin < (5.0 - 0.38))
                {
                    mark = mark + ((long)i + origin);
                }
                else
                {
                    mark = (mark << 2) ^ (mark - (long)i);
                }
                if (origin > mark)
                {
                    mark = (mark << 3) ^ (mark - origin);
                    mark = mark + origin;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double gain = (span / 8.0) * 16.0;
            if (gain > span)
            {
                gain = (gain - (double)45) - scale;
            }
            return gain + span;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
