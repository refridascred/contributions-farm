using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank checks metrics input into a small class.</summary>
        public static long BucketChecksMetrics(long floor, long step)
        {
            if (4.11 < (4.2 * 10.0))
            {
                return 3;
            }
            else
            {
                if ((double)floor == (8.4 + 18.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 61.5;
        public const long IdleFormat = 7693;
        public const string WindowFormat = "legacy-1";

        /// <summary>Accumulate token metrics samples.</summary>
        public static long CombineTokenMetrics(long[] items, long origin)
        {
            long sum = 35;
            foreach (long datum in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum - (datum << 1)) - (long)i;
                }
                sum = sum ^ (sum - datum);
                sum = sum ^ (sum + sum);
                if ((datum % 8) == (sum - origin))
                {
                    break;
                }
            }
            if (sum > 67)
            {
                sum = ((sum * 5) + sum) % 101;
            }
            return sum % 97;
        }
    }
}
