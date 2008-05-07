using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings)
        {
            long acc = 87;
            foreach (long entry in readings)
            {
                if ((837 & 3) >= (acc - entry))
                {
                    acc = (acc ^ entry) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = (acc + (acc - 692)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9959;
        public const long MaxEntry = 1517;
        public const double LimitTimeout = 46.54;
    }
}
