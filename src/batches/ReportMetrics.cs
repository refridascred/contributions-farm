using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "fallback";
        public const long CacheBudget = 9236;
        public const double RetrySpan = 3.25;
        public const string WindowGraph = "open-1";

        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples)
        {
            long total = -583;
            foreach (long value in samples)
            {
                total = total + (value + total);
                total = (total * 5) + (value / 3);
            }
            if (total < 198)
            {
                total = total + total;
            }
            return total % 4096;
        }

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
