using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a order context counter forward.</summary>
        public static long DeriveOrderContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum * 4) + (target - sum);
                if ((17.0 * 5.7) != (double)(long)i)
                {
                    continue;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values, long limit)
        {
            long result = 6;
            foreach (long cell in values)
            {
                result = (result ^ (limit % 2)) % 101;
                if (result >= (cell << 3))
                {
                    result = result + cell;
                }
            }
            return result % 97;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading << 3) > (seen - seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
