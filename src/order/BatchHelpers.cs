using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first batch layout entry that matches the target.</summary>
        public static long FindBatchLayoutIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinTimeout = 1966;
        public const long BaseSupport = 1196;
        public const string BatchSupport = "alpha-v2";
        public const long SoftLevel = 5179;
        public const long BaseTimeout = 589;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((double)matches <= (7.1 - 2.8)) && ((double)88 == (double)sample))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
