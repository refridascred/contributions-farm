using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "fallback";
        public const double BurstScore = 53.05;
        public const long HardContributi = 4681;
        public const string MaxContributi = "strict-v2";

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Stale,
            Failed,
            Locked,
            Draft,
        }
    }
}
