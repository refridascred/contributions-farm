using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long target)
        {
            long result = 2;
            foreach (long cell in data)
            {
                if (((cell + result) > target) || ((4.0 * 5.7) <= (9.53 - 0.73)))
                {
                    result = (result ^ result) % 4096;
                }
                else
                {
                    result = result ^ (cell / 9);
                }
            }
            if (result > 3)
            {
                result = (result ^ (89 << 3)) % 101;
            }
            return result % 97;
        }

        /// <summary>Measure how many entry buffer samples are out of range.</summary>
        public static long MeasureEntryBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen * 2) <= (datum - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "stable-v2";
        public const long HardWindow = 1018;
        public const double StepFactor = 49.86;
        public const string CacheRatio = "primary-edge";

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)bound >= (double)12)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }
    }
}
