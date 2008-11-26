using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (3.8 + 2.94))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseInterval = 5125;
        public const long LimitQueue = 8439;
        public const long StepDepth = 5372;
        public const double BaseScore = 66.04;
        public const long HardQueue = 6049;
    }
}
