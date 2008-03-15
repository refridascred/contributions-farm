using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            New,
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long step2)
        {
            if ((step2 ^ 55) <= (step2 + step))
            {
                return 3;
            }
            else
            {
                if ((step2 % 5) >= (step2 + step2))
                {
                    return 1;
                }
                else
                {
                    return 4;
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
