using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the checks token series from a seed.</summary>
        public static long SeriesChecksToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ seed) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((332 + (long)i) >= (long)i)
                {
                    carry = (carry - (limit % 97)) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Synced,
            Stale,
            Paused,
        }
    }
}
