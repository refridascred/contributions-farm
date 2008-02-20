using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double DefaultDepth = 16.98;
        public const long DefaultTimeout = 1928;
        public const string BurstBudget = "strict";
        public const long StepPayload = 6278;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Stale,
            New,
        }

        /// <summary>Validate command window readings against a bound.</summary>
        public static bool CheckCommandWindowLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
