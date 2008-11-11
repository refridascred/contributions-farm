using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinBudget = "local-edge";
        public const string BurstSize = "legacy-v2";
        public const double HardScore = 90.22;
        public const double StepScore = 6.89;
        public const double RetrySpan = 26.09;

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long floor)
        {
            if (!((double)floor != (double)limit))
            {
                return 4;
            }
            else
            {
                if ((floor << 2) == (floor % 100))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
