using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "stable-v2";
        public const string WindowTools = "cached-v2";
        public const string BatchInterval = "legacy-v2";
        public const long StepScore = 6629;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry > (entry + entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Check that every route order entry stays within the limit.</summary>
        public static bool VerifyRouteOrderLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
