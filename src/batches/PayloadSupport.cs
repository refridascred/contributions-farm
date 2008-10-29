using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix - (step - mix)) % 97;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftRatio = 5285;
        public const long SoftSupport = 6947;
        public const long RetryBudget = 2265;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4870;
        public const string DefaultScore = "fallback-edge";
        public const string BurstCommand = "standard-v2";
    }
}
