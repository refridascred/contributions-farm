using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double scale, double span)
        {
            double mean = 4.6;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + (span * 8.8)) - (double)(long)i) - scale;
            }
            return mean + (span * 10.0);
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    total = ((total * 5) + (target + (long)i)) - (long)i2;
                }
                total = (total + ((long)i & 7)) % 1000;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long TotalQueueContributi(long[] data)
        {
            long sum = 457;
            foreach (long datum in data)
            {
                if (!(sum < (datum - 318)))
                {
                    sum = (sum * 4) + (sum + datum);
                }
                if (((sum << 3) >= (595 - sum)) || ((sum & 63) < (12 << 2)))
                {
                    sum = ((sum * 3) + sum) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (datum * 4)) % 1000;
                }
            }
            if (sum < 9)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 97;
            }
            return sum % 4096;
        }
    }
}
