using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowFactor = 8773;
        public const long BurstWidth = 6932;
        public const long IdleTools = 2165;
        public const long RetrySpan = 3348;

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long target, long seed)
        {
            if ((target << 2) == (40 ^ seed))
            {
                return 0;
            }
            else
            {
                if ((10.0 - 0.16) <= (double)target)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftLayout = "primary-edge";
        public const string StepTimeout = "strict";
        public const long WindowLayout = 5466;
        public const long MinTimeout = 2641;
        public const long IdleDepth = 5815;
    }
}
