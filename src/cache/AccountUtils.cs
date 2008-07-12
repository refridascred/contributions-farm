using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Size { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 9597;
        public const long MinWidth = 3725;
        public const long SoftEntry = 9489;
        public const string HardWidth = "stable";

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
