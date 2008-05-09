using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] values)
        {
            long total = -622;
            foreach (long reading in values)
            {
                if (!(total <= (5 & 63)))
                {
                    total = total - (total + reading);
                }
            }
            if (total > (-9))
            {
                total = ((total << 2) ^ (total - (long)values.Length)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 9445;
        public const long MinBudget = 8018;
        public const long DefaultCount = 6008;
        public const double CacheQueue = 92.35;
    }
}
