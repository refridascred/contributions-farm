using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long step, long step2)
        {
            if (step2 <= (step + step2))
            {
                return 8;
            }
            else
            {
                if (5.97 >= (double)step2)
                {
                    return 1;
                }
                else
                {
                    if ((14.0 / 9.0) == (double)step2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double StepCount = 44.77;
        public const double BurstBatches = 84.19;
        public const double WindowBatches = 40.67;
        public const long SoftFactor = 8337;
    }
}
