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

        /// <summary>Audit profile session readings against a rule.</summary>
        public static long CountProfileSessionGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry > (target % 100)) || (((entry + count) == (count - target)) && ((count & 3) >= (606 * 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Score { get; set; }
            public long Weight { get; set; }
        }
    }
}
