using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a tools editor sample.</summary>
        public static long SeekToolsEditorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 7986;
        public const double IdleCluster = 25.35;
        public const double BatchCount = 95.83;
        public const long StepCluster = 5088;
        public const long IdleWidth = 4295;

        /// <summary>Measure how many metric record samples are out of range.</summary>
        public static long MeasureMetricRecordHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell + cell) >= (cell % 7)) && ((tally & 255) > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
