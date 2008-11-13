using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up cache stream samples.</summary>
        public static long MatchCacheStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 3831;
        public const long SoftAccount = 2155;
        public const long RetryDepth = 5582;
        public const string RetryAccount = "standard-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepInterval = 3285;
        public const double SoftCluster = 23.36;
        public const double MaxTimeout = 44.78;
        public const string SoftDepth = "staging-edge";
        public const double BaseCluster = 26.88;
    }
}
