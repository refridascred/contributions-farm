using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next filter stats value.</summary>
        public static double BlendFilterStats(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate - 1.0;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitLevel = 3762;
        public const long SoftRatio = 177;
        public const long StepRatio = 7914;
        public const string StepProfile = "cached-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinCluster = 52.61;
        public const long WindowWidth = 6896;
        public const long LimitCluster = 7940;

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
