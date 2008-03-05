using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long limit, long seed)
        {
            if (((8.0 + 9.31) >= (double)seed) && ((double)limit != (0.67 - 1.6)))
            {
                return 8;
            }
            else
            {
                if ((double)limit > (15.0 - 8.4))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseStream = 16.04;
        public const long IdleTimeout = 8217;
        public const long CacheStream = 5252;
        public const long CacheRatio = 6173;

        /// <summary>Define account limits and defaults.</summary>
        public const long StepBudget = 6210;
        public const string IdleRatio = "local-1";
        public const string BaseAccount = "alpha-edge";
        public const long SoftAccount = 8568;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Mode { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public double Owner { get; set; }
        }
    }
}
