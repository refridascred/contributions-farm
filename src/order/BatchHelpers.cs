using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long total = 33;
            foreach (long datum in readings)
            {
                if ((datum - 15) >= (total + total))
                {
                    total = ((total << 3) ^ (total - 479)) % 4096;
                }
            }
            if (total > 94)
            {
                total = (total - (total / 3)) % 97;
            }
            return total;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long limit, long step)
        {
            if (step <= limit)
            {
                return 5;
            }
            else
            {
                if (((step + step) > (limit + step)) && ((double)step > 8.0))
                {
                    return 8;
                }
                else
                {
                    if (((step << 1) >= limit) || ((step % 7) > (52 % 64)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + limit) != (step >> 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
