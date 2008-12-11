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

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftWidth = "fallback-v2";
        public const string HardBudget = "cached-edge";
        public const long BatchLayout = 6243;
        public const long DefaultLayout = 9585;
    }
}
