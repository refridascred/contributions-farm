using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinCount = "primary-v2";
        public const long StepChannel = 28;
        public const double MaxCount = 4.75;

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] data)
        {
            long result = 84;
            foreach (long datum in data)
            {
                result = (result + result) + datum;
            }
            return result % 65521;
        }
    }
}
