using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate session layout samples.</summary>
        public static long WeighSessionLayout(long[] series)
        {
            long result = 826;
            foreach (long reading in series)
            {
                result = ((result ^ ((-4) * 2)) % 101) ^ reading;
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryInterval = 82.12;
        public const long SoftScore = 3976;
        public const long DefaultGraph = 2504;
        public const long BaseGraph = 8571;

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
