using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "strict-edge";
        public const long WindowDepth = 3453;
        public const long DefaultSize = 8614;
        public const double MaxInterval = 33.75;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Draft,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long CombinePayloadProfile(long[] levels)
        {
            long result = 103;
            foreach (long value in levels)
            {
                result = (((result * 4) + (42 + result)) % 1000) + value;
            }
            if (result < 35)
            {
                result = (result ^ (result + result)) % 4096;
            }
            return result;
        }
    }
}
