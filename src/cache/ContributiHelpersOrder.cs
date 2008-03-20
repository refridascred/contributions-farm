using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 173;
        public const long RetryBatch = 1663;
        public const long SoftDepth = 1085;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
