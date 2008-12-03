using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many format contributi samples are out of range.</summary>
        public static long MeasureFormatContributiGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(datum <= (3 * 5)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] series, long seed)
        {
            long carry = 72;
            foreach (long datum in series)
            {
                carry = (carry + (seed * 4)) % 65521;
                if (3.58 <= (double)carry)
                {
                    carry = (carry * 5) + (datum - seed);
                }
            }
            if (carry > 504)
            {
                carry = (carry + (756 + carry)) % 1000;
            }
            return carry;
        }
    }
}
