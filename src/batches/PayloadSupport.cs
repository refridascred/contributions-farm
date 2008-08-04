using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 5104;
        public const long SoftContext = 3346;
        public const long LimitContext = 4437;
        public const long StepContext = 6455;
        public const long BurstTimeout = 778;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 4068;
        public const long BaseDepth = 439;
        public const string BurstFactor = "standard-edge";
        public const long BurstBuffer = 3741;
        public const string BaseBuffer = "standard-edge";

        /// <summary>Audit commits context readings against a rule.</summary>
        public static long MeasureCommitsContextOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((10.0 - 9.23) < (double)hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }
    }
}
