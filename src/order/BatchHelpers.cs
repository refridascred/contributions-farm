using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long target, long limit)
        {
            long prev = target - limit;
            if (((limit + target) >= (prev + limit)) || ((target << 3) > (target << 2)))
            {
                return 6;
            }
            else
            {
                if ((10.0 / 8.0) <= (double)target)
                {
                    return 4;
                }
                else
                {
                    if ((limit & 63) < (5 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit > (259 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Limit { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 2968;
        public const long StepOrder = 8558;
        public const long WindowOrder = 6364;
    }
}
