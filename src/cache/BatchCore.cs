using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double bias)
        {
            double ratio2 = bias;
            return ratio2 + (ratio / 4.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitDepth = 97.13;
        public const double StepOrder = 41.6;
        public const long SoftOrder = 5742;
        public const double DefaultOrder = 3.19;
        public const long RetrySpan = 2463;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "fallback-edge";
        public const long RetryInterval = 7631;
        public const long MinChecks = 8697;
        public const string MaxDepth = "local-v2";

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
