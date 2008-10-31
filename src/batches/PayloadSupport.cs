using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MinScore = 89.99;
        public const long HardSize = 3778;
        public const long MinRoute = 3031;
        public const string HardLevel = "alpha-edge";
        public const string SoftDepth = "strict-edge";

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Check that every checks command entry stays within the limit.</summary>
        public static bool CheckChecksCommandLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
