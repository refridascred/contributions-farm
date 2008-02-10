using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowCount = 6189;
        public const long WindowInterval = 1376;
        public const double WindowTimeout = 83.26;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long RollReport(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = ((result << 3) ^ result) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
