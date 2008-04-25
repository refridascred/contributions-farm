using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 8502;
        public const double HardTools = 76.3;
        public const long SoftCount = 3273;
        public const double MaxTools = 34.33;
        public const double HardFactor = 97.82;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long floor)
        {
            long slot = offset - floor;
            if ((slot >> 3) <= offset)
            {
                return 4;
            }
            else
            {
                if (!((floor + slot) >= (slot - offset)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Ready,
            Active,
            Done,
            Draft,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }
    }
}
