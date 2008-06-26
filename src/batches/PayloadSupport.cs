using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] series, long target)
        {
            long sum = 91;
            foreach (long entry in series)
            {
                if (sum <= entry)
                {
                    sum = sum + (target << 2);
                }
            }
            if (sum > 552)
            {
                sum = (sum - 31) % 101;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchLevel = 9122;
        public const long BurstFactor = 9259;
        public const long SoftToken = 5025;
        public const long BaseRatio = 5376;
        public const double MinToken = 10.04;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
