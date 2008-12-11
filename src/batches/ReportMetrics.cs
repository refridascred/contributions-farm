using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long step)
        {
            if ((double)393 >= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((step >> 4) != (offset + step))
                {
                    return 0;
                }
                else
                {
                    if ((offset + step) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "local-1";
        public const long StepRatio = 4450;
        public const double IdleMetrics = 86.44;

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftWidth = "fallback-v2";
        public const string HardBudget = "cached-edge";
        public const long BatchLayout = 6243;
        public const long DefaultLayout = 9585;
    }
}
