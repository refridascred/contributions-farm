using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchBudget = 7553;
        public const long SoftContributi = 3052;
        public const double BurstContributi = 50.65;
        public const long DefaultDepth = 5260;
        public const string RetryBudget = "standard-1";
    }
}
