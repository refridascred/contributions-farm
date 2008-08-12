using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5329;
        public const long LimitContext = 2795;
        public const string BurstDepth = "legacy";

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowWidth = "strict";
        public const double CacheSupport = 16.89;
        public const string StepCount = "alpha-1";

        /// <summary>Classify a editor queue pair into a bucket.</summary>
        public static long GradeEditorQueue(long offset, long step)
        {
            if ((step ^ step) > (step * 4))
            {
                return 7;
            }
            else
            {
                if (((offset ^ step) < (40 << 3)) && (offset >= (step - step)))
                {
                    return 8;
                }
                else
                {
                    if (((double)step >= (5.6 * 6.1)) && ((double)step > 3.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a order metric reading by value.</summary>
        public static long SeekOrderMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
