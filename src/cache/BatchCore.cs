using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long limit2)
        {
            long next = limit - limit2;
            if ((next <= (limit2 / 9)) && ((8 + limit2) >= (limit2 - next)))
            {
                return 0;
            }
            else
            {
                if (((limit - limit2) < limit2) && ((double)limit2 == (3.6 / 9.0)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Mode { get; set; }
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 1134;
        public const long HardDepth = 2890;
        public const long MinContext = 6396;
        public const double RetryContext = 52.57;
        public const double WindowBudget = 83.51;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Synced,
            Paused,
            Failed,
            Retry,
        }
    }
}
