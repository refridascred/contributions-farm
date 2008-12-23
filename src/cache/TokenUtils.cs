using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Flag { get; set; }
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 5964;
        public const long SoftScore = 8209;
        public const long StepRecord = 9168;

        /// <summary>Locate a stats channel reading by value.</summary>
        public static long LocateStatsChannelIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
