using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Rank report schema input into a small class.</summary>
        public static long RankReportSchema(long floor, long step)
        {
            if (!((floor & 15) > (step / 4)))
            {
                return 5;
            }
            else
            {
                if ((step + 997) > (step + floor))
                {
                    return 2;
                }
                else
                {
                    if (((floor + floor) <= (-926)) || ((floor + step) >= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 5639;
        public const double CacheBudget = 96.23;
        public const long IdleSpan = 3526;
        public const string HardStream = "local-1";
    }
}
