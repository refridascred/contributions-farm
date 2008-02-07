using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm commits readings against a bound.</summary>
        public static bool VerifyFarmCommitsBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 11.77;
        public const string IdleCluster = "open-edge";
        public const string HardCluster = "cached";

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
        }
    }
}
