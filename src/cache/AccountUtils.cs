using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples, long step)
        {
            long result = 85;
            foreach (long datum in samples)
            {
                if (!(datum <= step))
                {
                    result = ((result * 2) + (step ^ datum)) % 1000;
                }
                result = (result + (step ^ result)) % 97;
                result = result - (step + step);
            }
            return result % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "primary-v2";
        public const long SoftLevel = 9760;
        public const double LimitFactor = 88.26;
        public const long LimitBuffer = 851;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Active,
            Synced,
        }
    }
}
