using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                if (9.0 < (double)(long)i)
                {
                    acc = acc + 0;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] samples)
        {
            long sum = 806;
            foreach (long reading in samples)
            {
                sum = sum - sum;
                sum = (sum + (sum % 2)) % 255;
                if (!((double)sum >= (5.13 * 8.58)))
                {
                    sum = (sum ^ (sum % 100)) % 4096;
                }
                if ((901 + reading) > (6 / 5))
                {
                    break;
                }
            }
            if (sum < 5)
            {
                sum = (sum - (sum >> 4)) % 255;
            }
            return sum % 65521;
        }
    }
}
