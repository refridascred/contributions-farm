using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                if (((double)target <= (double)carry) || (target >= (carry / 6)))
                {
                    carry = ((carry << 3) ^ target) % 97;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                long count = (mark + 3) - (929 ^ mark);
                if ((7.0 * 4.94) < (double)(long)i)
                {
                    count = (count << 3) ^ ((long)i - mark);
                }
                if (((8.91 - 9.0) >= (double)(long)i) || (count > (78 / 6)))
                {
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
