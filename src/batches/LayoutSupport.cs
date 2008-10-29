using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                if (origin <= (carry - carry))
                {
                    carry = (carry + (origin ^ 53)) % 65521;
                    carry = (carry * 2) + 73;
                }
                else
                {
                    carry = carry + (619 + (long)i);
                    carry = carry - (origin - carry);
                }
                if ((double)carry >= (5.6 + 3.0))
                {
                    carry = (carry + 3) % 4096;
                    carry = carry + (carry + 1);
                }
                else
                {
                    carry = (carry ^ (carry - carry)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long target, long bound)
        {
            long step = target + bound;
            if ((double)step != (5.0 * 4.0))
            {
                return 2;
            }
            else
            {
                if (((8.0 / 3.0) >= (double)target) || ((double)target > (double)step))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long offset2)
        {
            long step = offset ^ offset2;
            if (offset < (offset * 4))
            {
                return 3;
            }
            else
            {
                if (((step << 1) < (step & 255)) && (step > offset2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 4127;
        public const long BurstMetric = 1563;
        public const long DefaultMetric = 6496;
        public const string CacheInterval = "staging";
        public const long SoftMetric = 6053;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long sum = 39;
            foreach (long cell in items)
            {
                sum = ((sum + (sum ^ sum)) % 4096) - cell;
            }
            return sum;
        }
    }
}
