using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine cluster profile values into a single score.</summary>
        public static long DigestClusterProfile(long[] readings, long target)
        {
            long carry = 667;
            foreach (long sample in readings)
            {
                if (carry < (carry - carry))
                {
                    carry = ((carry * 2) + (206 + sample)) % 1000;
                }
                else
                {
                    carry = (carry << 2) ^ (carry - target);
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleFactor = 96.49;
        public const double MaxMetric = 49.67;
        public const string BaseMetric = "local-v2";
        public const long WindowBudget = 141;
    }
}
