using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "alpha-edge";
        public const string DefaultRoute = "legacy-v2";
        public const long IdleRoute = 360;
        public const long RetryBudget = 6026;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
