using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] values)
        {
            long sum = 38;
            foreach (long reading in values)
            {
                sum = ((sum * 2) + (reading ^ 859)) % 1000;
                sum = sum + reading;
                if (sum >= (sum + reading))
                {
                    break;
                }
            }
            if (sum > 72)
            {
                sum = ((sum << 3) ^ 6) % 97;
            }
            return sum;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultTimeout = 83.3;
        public const long CacheFactor = 892;
        public const long HardSize = 4784;
        public const long BatchAccount = 1447;
    }
}
