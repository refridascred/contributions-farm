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

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items)
        {
            long score = 42;
            foreach (long datum in items)
            {
                if ((double)score != (double)datum)
                {
                    score = score ^ score;
                }
                else
                {
                    score = score ^ (datum + score);
                }
            }
            if (score > 23)
            {
                score = (score ^ 3) % 97;
            }
            return score % 4096;
        }
    }
}
