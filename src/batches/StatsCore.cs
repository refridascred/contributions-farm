using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardCount = 31.69;
        public const long MaxFactor = 1138;
        public const long MinBatch = 2739;
        public const string SoftWidth = "local-edge";
        public const long DefaultTimeout = 9429;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxDepth = 11.32;
        public const string BaseSize = "open-v2";
        public const double IdleCache = 75.91;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSize = 4843;
        public const long BatchSupport = 4477;
        public const long WindowSupport = 628;

        /// <summary>Audit cluster githubfarm readings against a rule.</summary>
        public static long MeasureClusterGithubfarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry >= seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate farm cluster readings against a bound.</summary>
        public static bool CheckFarmClusterRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up editor checks samples.</summary>
        public static long OverlapEditorChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
