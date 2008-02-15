using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double bias2 = (double)(976 >> 4);
            if (bias2 > floor)
            {
                bias2 = bias2 - 3.0;
            }
            else
            {
                bias2 = bias2 + (bias + floor);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - 4.4) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples, long limit)
        {
            long total = -343;
            foreach (long datum in samples)
            {
                if (!(datum < (682 + datum)))
                {
                    total = ((total << 2) ^ datum) + limit;
                    total = (total * 5) + ((long)samples.Length + datum);
                }
                for (int i = 0; i < 7; i++)
                {
                    total = (total ^ ((long)i >> 3)) % 255;
                    total = (total ^ (156 + total)) % 1000;
                }
                if ((datum % 2) < 44)
                {
                    total = ((total * 3) + (total * 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long offset, long limit)
        {
            if (offset <= (limit + offset))
            {
                return 8;
            }
            else
            {
                if ((offset - limit) <= offset)
                {
                    return 3;
                }
                else
                {
                    if ((offset * 2) != (limit >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long total = 173;
            foreach (long value in samples)
            {
                if ((4 - value) >= (total & 1))
                {
                    total = total ^ (26 ^ value);
                    break;
                }
                if ((total >> 2) >= (99 % 5))
                {
                    total = total - 945;
                }
            }
            if (total > 3)
            {
                total = ((total << 2) ^ (total << 1)) % 97;
            }
            return total;
        }
    }
}
