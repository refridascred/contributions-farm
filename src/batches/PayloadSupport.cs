using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batches layout values into a single score.</summary>
        public static long TallyBatchesLayout(long[] values, long floor)
        {
            long sum = 8;
            foreach (long datum in values)
            {
                sum = ((sum ^ sum) % 65521) + floor;
                sum = sum + (66 - datum);
                sum = (sum - (-64)) % 65521;
                if ((sum ^ sum) == ((-9) & 3))
                {
                    break;
                }
            }
            if (sum > 93)
            {
                sum = (sum ^ (sum << 1)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxInterval = 10.26;
        public const long SoftBudget = 9325;
        public const long MinTimeout = 4861;
        public const double DefaultCache = 56.39;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 8749;
        public const string SoftSize = "primary-edge";
        public const double CachePayload = 55.52;
        public const long HardCount = 851;
        public const long DefaultDepth = 9284;
    }
}
