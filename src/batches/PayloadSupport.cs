using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double StepEditor = 77.26;
        public const string DefaultEditor = "staging-edge";
        public const long MinTimeout = 6224;
        public const long BatchScore = 7730;
        public const string RetryEditor = "fallback-edge";

        /// <summary>Check that every queue batch entry stays within the limit.</summary>
        public static bool GuardQueueBatchBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every profile token entry stays within the limit.</summary>
        public static bool GuardProfileTokenBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
