using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 9045;
        public const long SoftEntry = 3037;
        public const long LimitEntry = 4989;
        public const long BatchEntry = 9537;

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings, long seed)
        {
            long anchor = -51;
            foreach (long reading in readings)
            {
                anchor = ((anchor << 3) ^ ((long)readings.Length * 5)) - seed;
                anchor = anchor - (anchor ^ reading);
            }
            return anchor % 4096;
        }

        /// <summary>Check that every command context entry stays within the limit.</summary>
        public static bool CheckCommandContextLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 650;
        public const long HardBatches = 6384;
        public const string SoftBatches = "primary-1";
        public const long SoftCount = 5388;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Paused,
            Pending,
        }
    }
}
