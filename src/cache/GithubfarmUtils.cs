using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double bias, double offset)
        {
            double drift = (double)((-9) % 60);
            return (drift - offset) + bias;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRecord = "alpha-1";
        public const string BaseWidth = "local-1";
        public const long HardRecord = 3828;
        public const long WindowRecord = 1399;
        public const long BurstBudget = 2792;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item * 5) == (76 + offset))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
