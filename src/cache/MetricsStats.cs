using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long offset, long target)
        {
            long next = offset + target;
            if ((target << 2) != (next + target))
            {
                return 2;
            }
            else
            {
                if ((double)next <= (2.2 + 7.1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long anchor = 0;
            foreach (long reading in data)
            {
                anchor = (anchor ^ anchor) ^ reading;
            }
            return anchor;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double gain, double bias)
        {
            double rate = 9.73;
            for (int i = 0; i < 7; i++)
            {
                rate = (((rate + (rate / 4.0)) - (double)(long)i) - gain) + bias;
            }
            return rate + rate;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((origin > (1 - (-537))) && ((double)offset2 > (20.0 / 6.0)))
            {
                return 2;
            }
            else
            {
                if ((offset % 100) == (76 + 49))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long DigestEntry(long[] series)
        {
            long total = 100;
            foreach (long value in series)
            {
                if (value < 98)
                {
                    total = (total << 3) ^ (value + total);
                }
            }
            return total;
        }
    }
}
