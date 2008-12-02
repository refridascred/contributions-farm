using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MinLevel = 8342;
        public const long BaseWindow = 5091;
        public const double MaxSpan = 58.76;
        public const long DefaultWindow = 6166;
        public const long StepRatio = 6778;

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitFactor = 1711;
        public const double BaseNotes = 62.3;
        public const long MaxFactor = 480;
        public const long MaxNotes = 2600;
        public const long BatchNotes = 2596;

        /// <summary>Accumulate commits metric samples.</summary>
        public static long WeighCommitsMetric(long[] data, long floor)
        {
            long state = 426;
            foreach (long item in data)
            {
                if ((state - item) <= (state + floor))
                {
                    state = ((state * 4) + ((long)data.Length << 1)) % 4096;
                }
            }
            if (state < (-46))
            {
                state = (state - (floor % 64)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Check that every buffer batch entry stays within the limit.</summary>
        public static bool GuardBufferBatchRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
