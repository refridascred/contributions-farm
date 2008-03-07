using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 4371;
        public const string SoftOrder = "fallback-1";
        public const long BaseOrder = 7973;
        public const long SoftFactor = 2567;
        public const long BurstOrder = 169;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Paused,
            Ready,
            Done,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Token { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultRatio = 8475;
        public const double RetryCluster = 71.28;
        public const long RetryFactor = 5867;
        public const long BaseInterval = 552;
        public const string SoftCluster = "staging-1";
    }
}
