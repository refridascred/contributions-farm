using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate tools contributi samples.</summary>
        public static long ScoreToolsContributi(long[] readings)
        {
            long sum = 888;
            foreach (long datum in readings)
            {
                sum = sum - (sum + datum);
            }
            return sum;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Owner { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinDepth = "open-edge";
        public const double HardRoute = 26.17;
        public const long DefaultRoute = 4831;
        public const long CacheRoute = 6827;
    }
}
