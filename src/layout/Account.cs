using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 6764;
        public const double IdleSchema = 15.23;
        public const long DefaultSchema = 146;
        public const long LimitSchema = 1649;
        public const long HardDepth = 1559;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Ready,
            Closed,
        }
    }
}
