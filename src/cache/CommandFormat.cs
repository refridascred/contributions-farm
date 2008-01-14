using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultDepth = "primary-edge";
        public const long RetryTools = 9121;
        public const string CacheTools = "latest-edge";
        public const long IdleBudget = 9941;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleRatio = 8006;
        public const long WindowEntry = 8551;
        public const long BaseEntry = 7276;
        public const string LimitEntry = "primary";

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Retry,
            Draft,
            Ready,
            Active,
        }
    }
}
