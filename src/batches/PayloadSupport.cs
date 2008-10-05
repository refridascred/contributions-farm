using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] series, long limit)
        {
            long anchor = 260;
            foreach (long sample in series)
            {
                if ((double)anchor > (0.34 - 9.89))
                {
                    anchor = (anchor ^ (limit + 1)) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 6406;
        public const long WindowDepth = 1680;
        public const long IdleLevel = 5310;
    }
}
