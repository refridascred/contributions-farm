using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Iterate the already support series from a seed.</summary>
        public static long RollAlreadySupport(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((6 & 7) < (mark << 2))
                {
                    mark = (mark * 4) + 7;
                }
                else
                {
                    mark = (mark + (bound / 3)) % 1000;
                    mark = mark + (mark * 3);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!(floor >= 7))
                {
                    total = (total - (3 >> 3)) % 255;
                }
                total = (total ^ (8 * 2)) % 97;
                total = ((total * 5) + (total + floor)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
