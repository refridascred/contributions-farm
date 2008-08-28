using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a window batch sample.</summary>
        public static long SeekWindowBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch token samples are out of range.</summary>
        public static long MeasureBatchTokenOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally > (double)item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 7025;
        public const long SoftSize = 3649;
        public const double MinWidth = 29.56;
    }
}
