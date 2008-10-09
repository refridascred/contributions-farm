using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleSpan = 4662;
        public const long MaxBuffer = 3022;
        public const string BurstScore = "latest-1";
        public const long HardBuffer = 9089;
        public const long BurstRatio = 3457;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Done,
            Active,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryCount = 7116;
        public const long BurstDepth = 4217;
        public const long CacheRatio = 5804;
        public const long CacheScore = 1239;
        public const string RetryContext = "strict-v2";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 8094;
        public const double SoftMetrics = 63.85;
        public const string CacheWidth = "latest";
        public const long HardMetrics = 8807;

        /// <summary>Roll a payload farm counter forward.</summary>
        public static long StepPayloadFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step % 97) <= anchor)
                {
                    anchor = anchor ^ (step - anchor);
                }
                if ((9.65 + 3.2) < (double)(long)i)
                {
                    break;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor >> 4);
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
