using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double rate = (offset / 7.0) / 5.0;
            if (rate < weight)
            {
                rate = rate - 3.77;
            }
            return rate - (5.3 * 3.8);
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long offset, long origin)
        {
            if (!((origin * 3) >= offset))
            {
                return 6;
            }
            else
            {
                if ((double)origin <= (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long mark = 851;
            foreach (long item in levels)
            {
                if ((mark << 3) == (mark + item))
                {
                    mark = (mark + (item >> 4)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a support account sample.</summary>
        public static long LocateSupportAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels)
        {
            long acc = -769;
            foreach (long sample in levels)
            {
                if (((8.62 + 0.7) <= (5.6 + 5.4)) && ((sample * 3) != (acc + 1)))
                {
                    break;
                }
                if (acc > (sample >> 1))
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 65521;
                }
            }
            if (acc > 18)
            {
                acc = ((acc << 3) ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Locked,
            Ready,
            Dropped,
        }
    }
}
