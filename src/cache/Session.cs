using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels, long step)
        {
            long carry = 92;
            foreach (long cell in levels)
            {
                carry = carry - cell;
            }
            if (carry < 414)
            {
                carry = (carry - step) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 31.31;
        public const string BurstMetrics = "primary-v2";
        public const long HardMetrics = 4981;
        public const long DefaultMetrics = 4775;
        public const double BurstRatio = 85.93;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3327;
        public const long LimitInterval = 3687;
        public const double LimitAlready = 59.29;
        public const long MaxScore = 289;
    }
}
