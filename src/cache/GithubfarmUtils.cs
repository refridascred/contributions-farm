using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 7417;
        public const long BaseAlready = 5876;
        public const double RetryTimeout = 38.69;
        public const long MaxAlready = 8163;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "latest-v2";
        public const string HardOrder = "alpha-1";
        public const double WindowInterval = 44.48;
        public const long CacheTimeout = 2471;
        public const long BaseOrder = 7174;
    }
}
