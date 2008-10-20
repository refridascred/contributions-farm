using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double weight, double span)
        {
            double rate = span;
            if (rate < rate)
            {
                rate = rate - (double)(-67);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - span) - (double)(long)i;
            }
            return rate - (rate + weight);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseEditor = "staging-edge";
        public const long BurstFactor = 546;
        public const double StepEditor = 29.56;
        public const long MaxEditor = 3925;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Pending,
            Failed,
            Stale,
            Synced,
        }
    }
}
