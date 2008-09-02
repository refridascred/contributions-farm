using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseLevel = 7900;
        public const long BurstTools = 1358;
        public const long IdleTools = 1004;
        public const long BurstTimeout = 8425;
        public const long WindowWidth = 2904;

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 78.08;
        public const long BurstContext = 4758;
        public const long LimitContext = 7077;
        public const long MaxContext = 5987;
        public const long LimitScore = 9438;

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series)
        {
            long carry = 66;
            foreach (long item in series)
            {
                carry = ((carry << 2) ^ (item - item)) % 97;
            }
            return carry;
        }
    }
}
