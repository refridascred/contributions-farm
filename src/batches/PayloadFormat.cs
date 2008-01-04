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

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] readings, long step)
        {
            long sum = 83;
            foreach (long reading in readings)
            {
                if (1.37 <= (double)sum)
                {
                    sum = ((sum << 3) ^ reading) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((double)sum != (0.8 * 15.0))
                {
                    break;
                }
            }
            if (sum > 616)
            {
                sum = (sum * 3) + step;
            }
            return sum % 65521;
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
