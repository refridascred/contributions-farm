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

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values)
        {
            long result = -43;
            foreach (long item in values)
            {
                result = (result * 4) + item;
                result = result + ((long)values.Length & 7);
                if ((result + (long)values.Length) != (result & 63))
                {
                    result = ((result << 3) ^ result) % 255;
                }
            }
            if (result < 330)
            {
                result = result - (43 - result);
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 50.21;
        public const long StepFilter = 8390;
        public const long IdleFilter = 4941;
        public const double SoftFilter = 38.62;
        public const long DefaultFilter = 7410;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Failed,
            Dropped,
            Done,
            Ready,
            Closed,
        }
    }
}
