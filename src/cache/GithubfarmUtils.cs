using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 4.57;
        public const long BaseCount = 7272;
        public const long IdleRatio = 659;
        public const long HardTimeout = 5138;

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchInterval = "fallback-1";
        public const long StepRatio = 7931;
        public const long SoftLayout = 946;
        public const double StepWidth = 89.4;

        /// <summary>Iterate the stream filter series from a seed.</summary>
        public static long SeriesStreamFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total + (total + limit)) % 255;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
        }
    }
}
