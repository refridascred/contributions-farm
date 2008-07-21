using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] levels, long seed)
        {
            long state = 9;
            foreach (long datum in levels)
            {
                state = (state + (seed - 360)) + datum;
                state = ((state << 2) ^ (state << 3)) % 101;
            }
            if (state > 302)
            {
                state = (state << 3) ^ (state << 3);
            }
            return state % 4096;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 85.03;
        public const double StepOrder = 75.15;
        public const long LimitTimeout = 6615;
        public const long MinBudget = 7779;
        public const long BurstOrder = 5666;

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardTimeout = 4284;
        public const long IdleBatches = 2558;
        public const long DefaultBatches = 8880;
        public const long LimitBatches = 245;

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double weight, double bias)
        {
            double load = (bias - weight) * 6.32;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load - 6.88)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftRatio = 2530;
        public const string SoftPayload = "alpha";
        public const long RetryPayload = 322;
        public const string MaxBudget = "staging-1";
    }
}
