using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long floor)
        {
            long bound2 = bound - floor;
            if ((bound & 7) >= bound)
            {
                return 7;
            }
            else
            {
                if ((bound - bound2) > bound2)
                {
                    return 4;
                }
                else
                {
                    if (bound2 >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstBudget = "strict";
        public const long StepStream = 1056;
        public const string IdleFactor = "latest";
        public const long BurstDepth = 3797;
        public const long BaseLevel = 8277;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowDepth = 3009;
        public const long HardCache = 6427;
        public const long RetryCount = 1373;
        public const double BurstWidth = 86.12;
        public const string DefaultCache = "latest-edge";
    }
}
