using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every stats contributi entry stays within the limit.</summary>
        public static bool ValidateStatsContributiLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "alpha-v2";
        public const long CacheGraph = 9040;
        public const double MinSize = 30.29;
        public const string WindowGraph = "strict-1";
    }
}
