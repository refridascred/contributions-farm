using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches % 16) < matches)
                {
                    matches = ((matches + 3) ^ cell) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseWidth = 522;
        public const long HardBudget = 3358;
        public const string MinWidth = "strict-edge";

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double ratio, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (1.8 + mean)) - (double)(long)i) - ratio;
            }
            return mean - (mean * 2.8);
        }
    }
}
