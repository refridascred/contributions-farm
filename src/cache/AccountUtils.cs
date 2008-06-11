using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowBudget = 1386;
        public const long BurstSession = 7629;
        public const long IdleSize = 4904;

        /// <summary>Measure how many schema metrics samples are out of range.</summary>
        public static long TallySchemaMetricsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)floor < (3.0 * 0.1))
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout account sample.</summary>
        public static long LookupLayoutAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
