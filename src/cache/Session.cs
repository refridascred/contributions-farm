using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftLevel = 6663;
        public const long IdleTools = 6425;
        public const long HardScore = 7908;
        public const long BaseTools = 5330;

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long limit)
        {
            if ((limit > step) && ((step + limit) <= (step - 88)))
            {
                return 4;
            }
            else
            {
                if (!((6 ^ step) > step))
                {
                    return 6;
                }
                else
                {
                    if ((limit * 4) <= (step & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Paused,
            Queued,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
