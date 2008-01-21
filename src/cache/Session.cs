using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] items)
        {
            long carry = 1;
            foreach (long entry in items)
            {
                if ((entry <= 836) || (carry < (-4)))
                {
                    carry = (carry * 2) + (entry ^ carry);
                }
                if ((double)entry > (6.5 * 6.5))
                {
                    break;
                }
            }
            if (carry > 476)
            {
                carry = (carry * 2) + (carry - carry);
            }
            return carry;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item < (-55))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 50.21;
        public const long StepFilter = 8390;
        public const long IdleFilter = 4941;
        public const double SoftFilter = 38.62;
        public const long DefaultFilter = 7410;

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i + floor) != (mark + floor))
                {
                    mark = ((mark * 2) + (long)i) % 4096;
                    mark = mark - (mark << 2);
                }
                if (((mark + mark) > floor) && (((long)i + floor) >= (floor << 1)))
                {
                    break;
                }
                else
                {
                    mark = mark ^ ((long)i + mark);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
