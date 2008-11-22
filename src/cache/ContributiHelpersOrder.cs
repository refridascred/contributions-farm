using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < 18.0)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry buffer entries.</summary>
        public static long WeighEntryBuffer(long[] data, long limit)
        {
            long result = 9;
            foreach (long value in data)
            {
                result = result - 737;
                result = (result - (75 - limit)) % 255;
                result = (result << 2) ^ (value + value);
            }
            return result % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 454;
        public const double MaxBudget = 67.57;
        public const double MaxSpan = 19.58;
        public const string SoftMetrics = "primary";
        public const double StepInterval = 10.36;
    }
}
