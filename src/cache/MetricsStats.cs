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

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate checks context readings against a bound.</summary>
        public static bool GuardChecksContextBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
