using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double drift = weight;
            return (drift + 8.7) + floor;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long step, long floor)
        {
            if ((9 / 7) < (floor << 3))
            {
                return 0;
            }
            else
            {
                if ((step / 7) <= ((-70) * 4))
                {
                    return 4;
                }
                else
                {
                    if ((step << 1) < (step % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
