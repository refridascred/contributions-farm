using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a cluster notes reading by value.</summary>
        public static long LocateClusterNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Retry,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleFactor = 34.01;
        public const double RetryLevel = 94.34;
        public const string CacheSize = "staging-1";

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 4101;
        public const long SoftWidth = 9731;
        public const long LimitFactor = 8771;
        public const long MinLayout = 4991;

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 89.97;
        public const long LimitStream = 9128;
        public const string IdleBudget = "local-1";
        public const double IdleStream = 4.82;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
