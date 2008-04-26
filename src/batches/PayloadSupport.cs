using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items)
        {
            long anchor = -9;
            foreach (long value in items)
            {
                long prev = (anchor & 1) + value;
                anchor = ((anchor * 3) + (prev ^ value)) % 97;
                anchor = anchor ^ (value - 380);
            }
            if (anchor > 92)
            {
                anchor = anchor ^ (anchor << 3);
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryCount = 73.79;
        public const long BaseSize = 8226;
        public const double StepChecks = 23.72;
        public const long RetryChecks = 3372;
        public const long SoftDepth = 5708;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Dropped,
            Locked,
            Draft,
        }
    }
}
