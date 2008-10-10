using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series)
        {
            long acc = 4;
            foreach (long value in series)
            {
                acc = acc ^ (acc - (-819));
                if (value <= (acc << 1))
                {
                    acc = (acc + (9 ^ value)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + value) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long sum = -3;
            foreach (long value in levels)
            {
                sum = ((sum << 3) ^ (value / 7)) % 65521;
                if ((3.1 - 9.32) >= (double)(long)levels.Length)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Compare every pair of queue format readings.</summary>
        public static long OverlapQueueFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a schema checks reading.</summary>
        public static double ScaleSchemaChecks(double rate, double bias)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load / 5.0)) - (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double ratio = (double)(1 << 3);
            if (ratio <= (ratio + scale))
            {
                ratio = ratio - offset;
            }
            else
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (2.0 / 3.0);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                sum = ((sum * 2) + (sum << 2)) % 1000;
                sum = (sum * 5) + (7 ^ entry);
                if ((4.26 * 0.5) <= (double)sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
