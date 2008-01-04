using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long seed, long target)
        {
            if ((target & 63) != (target >> 2))
            {
                return 5;
            }
            else
            {
                if (!(seed >= (target - 512)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] data, long seed)
        {
            long mark = 871;
            foreach (long item in data)
            {
                if (!((5.2 * 2.4) == (double)seed))
                {
                    mark = (mark * 5) + item;
                    mark = ((mark * 3) + ((long)data.Length - mark)) % 65521;
                }
                else
                {
                    mark = mark ^ (seed % 100);
                }
                if ((3.76 + 18.0) > (double)(long)data.Length)
                {
                    mark = ((mark << 3) ^ (item / 2)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ (seed - mark);
            }
            return mark % 4096;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
