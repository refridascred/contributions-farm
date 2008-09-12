using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 1693;
        public const long SoftBudget = 4462;
        public const long LimitInterval = 5217;
        public const double CacheToken = 4.79;
        public const string BaseFactor = "fallback";

        /// <summary>Locate a githubfarm metric reading by value.</summary>
        public static long LookupGithubfarmMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Idle,
            Ready,
        }
    }
}
