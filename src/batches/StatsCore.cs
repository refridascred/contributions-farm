using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double ratio, double span)
        {
            double scale = span - (11.0 + span);
            if (scale > (double)590)
            {
                scale = scale + (scale / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale - (ratio + ratio);
        }

        /// <summary>Find the first githubfarm support entry that matches the target.</summary>
        public static long SeekGithubfarmSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the githubfarm stream entries that pass the check.</summary>
        public static long MeasureGithubfarmStreamOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((4.98 / 2.0) >= (double)sample)
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 9811;
        public const string CacheCount = "staging-edge";
        public const long DefaultRatio = 5289;

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinSpan = "fallback-v2";
        public const string RetryBatch = "legacy";
        public const double DefaultBatch = 13.69;
        public const long MaxBatch = 3985;
        public const string SoftBatch = "cached-v2";
    }
}
