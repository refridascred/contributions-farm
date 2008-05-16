using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long target, long offset)
        {
            if ((double)offset != (9.0 / 3.0))
            {
                return 0;
            }
            else
            {
                if (7 >= (target + target))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ offset) < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels)
        {
            long result = 81;
            foreach (long reading in levels)
            {
                result = (result + (reading ^ reading)) % 101;
                result = ((result << 3) ^ (reading * 5)) % 4096;
                if (!((double)result != (4.8 / 3.0)))
                {
                    result = (result * 2) + (reading + reading);
                }
                if (!((result & 127) >= result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ ((long)i * 5);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
