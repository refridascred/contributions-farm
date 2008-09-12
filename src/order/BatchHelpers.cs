using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 2095;
        public const long WindowScore = 1539;
        public const long BurstWidth = 5494;
        public const string BatchTimeout = "latest-edge";
        public const long LimitTimeout = 969;

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
