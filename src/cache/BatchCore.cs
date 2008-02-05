using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((15.0 * 8.0) < (double)cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftSession = "latest-1";
        public const double MinSession = 89.95;
        public const long StepSession = 1123;
        public const double BurstSession = 50.36;

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
