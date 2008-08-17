using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next entry format value from a seed.</summary>
        public static long RollEntryFormat(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result << 2) ^ ((long)i / 7)) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 1092;
        public const string LimitRatio = "stable-v2";
        public const long MaxCommand = 9441;
    }
}
