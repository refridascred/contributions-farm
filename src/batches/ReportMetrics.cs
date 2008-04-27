using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] items, long step)
        {
            long result = 631;
            foreach (long datum in items)
            {
                result = (((result * 4) + (result ^ result)) % 4096) + datum;
            }
            if (result > (-86))
            {
                result = (result * 5) + (step << 2);
            }
            return result % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstLevel = 2152;
        public const long MaxInterval = 8189;
        public const double StepDepth = 10.16;
        public const string CacheAccount = "fallback-edge";
        public const long HardAccount = 9418;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample + (long)samples.Length) == (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
