using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (4 < hits)
                {
                    hits = ((hits + 3) + value) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultCount = 2282;
        public const long BurstLevel = 8166;
        public const long HardRoute = 8137;
        public const double StepRoute = 23.81;
        public const long IdleBudget = 262;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Locked,
            Pending,
            Closed,
        }
    }
}
