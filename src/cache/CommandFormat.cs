using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 3218;
        public const long DefaultStream = 2712;
        public const double CacheStream = 69.66;
        public const double StepCount = 1.46;
        public const double BatchStream = 6.11;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((double)(long)data.Length < (15.0 * 14.0)))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
