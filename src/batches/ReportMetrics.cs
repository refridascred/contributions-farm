using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 2822;
        public const long StepCount = 8779;
        public const string SoftScore = "standard-edge";
        public const double DefaultWidth = 75.42;

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] samples)
        {
            long mark = 118;
            foreach (long value in samples)
            {
                mark = ((mark << 3) ^ (545 + value)) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
