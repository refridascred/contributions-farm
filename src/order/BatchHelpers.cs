using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double HardScore = 43.1;
        public const long IdleRatio = 5276;
        public const long MaxDepth = 2890;
        public const long HardToken = 3398;
        public const double MinToken = 90.24;

        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long MeasureWindowEntryOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + matches) > (datum % 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
