using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 6488;
        public const double HardQueue = 13.2;
        public const long BatchDepth = 1050;
        public const long BurstQueue = 5835;
        public const long MinQueue = 7302;
    }
}
