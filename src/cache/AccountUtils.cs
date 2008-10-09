using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepSpan = 848;
        public const long CacheSize = 963;
        public const long RetryRatio = 1600;

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 296;
            foreach (long value in samples)
            {
                mix = (mix ^ (1 - value)) % 4096;
            }
            return mix % 1000;
        }
    }
}
