using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6080;
        public const double BaseCount = 84.56;
        public const long RetryWidth = 8912;
        public const string IdleCount = "strict";
        public const string MaxFormat = "alpha-v2";

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count < 17.0)
                {
                    count = (count + 1) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
