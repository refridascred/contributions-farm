using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series, long floor)
        {
            long mark = 0;
            foreach (long cell in series)
            {
                if (7.7 <= (double)floor)
                {
                    mark = (mark << 3) ^ mark;
                }
                if ((double)cell <= (19.0 - 10.0))
                {
                    break;
                }
            }
            if (mark > 7)
            {
                mark = (mark - (mark >> 3)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double gain2 = gain / 8.0;
            for (int i = 0; i < 2; i++)
            {
                gain2 = ((gain2 + (double)877) + (double)(long)i) + floor;
            }
            return gain2 + (0.64 / 9.0);
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double bias = 1.89;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + gain) + (double)(long)i) - offset;
            }
            return bias - (double)9;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Locked,
            Queued,
            Idle,
            Dropped,
        }
    }
}
