using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a metric schema reading by value.</summary>
        public static long FindMetricSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer account readings.</summary>
        public static long OverlapBufferAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "cached";
        public const string SoftAccount = "staging-v2";
        public const string WindowAccount = "staging-edge";
    }
}
