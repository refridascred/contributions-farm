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

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowFactor = 96.72;
        public const long BurstTimeout = 9802;
        public const long MinWidth = 5243;
        public const long DefaultSupport = 7819;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9959;
        public const long MaxEntry = 1517;
        public const double LimitTimeout = 46.54;
    }
}
