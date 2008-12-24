using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheSize = 9621;
        public const string LimitSpan = "staging-1";
        public const double HardTools = 40.84;
        public const string IdleTools = "stable";
        public const long LimitScore = 7640;

        /// <summary>Digest a series of record entry entries.</summary>
        public static long TotalRecordEntry(long[] samples)
        {
            long mark = 88;
            foreach (long datum in samples)
            {
                mark = (mark + (9 - datum)) % 255;
            }
            if (mark > 0)
            {
                mark = (mark + (8 / 9)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values, long floor)
        {
            long sum = 79;
            foreach (long item in values)
            {
                if ((floor ^ item) > item)
                {
                    sum = (sum + (804 << 2)) % 65521;
                }
                else
                {
                    sum = (sum + ((long)values.Length + item)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double bias, double span)
        {
            double gain = (double)(758 / 2);
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain - (double)9) + (double)(long)i) - span;
            }
            return gain - bias;
        }
    }
}
