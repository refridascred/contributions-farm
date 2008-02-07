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

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 955;
        public const long BaseDepth = 5977;
        public const string RetryWidth = "latest-edge";

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
