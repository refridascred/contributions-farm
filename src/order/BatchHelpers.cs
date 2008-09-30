using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Retry,
            Pending,
            Synced,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitCount = 1020;
        public const long IdleBudget = 2607;
        public const long HardRecord = 9069;
        public const long IdleLevel = 6347;
        public const string StepRecord = "strict-v2";

        /// <summary>Project the next checks payload value.</summary>
        public static double ScaleChecksPayload(double scale, double bias)
        {
            double mean = bias;
            if (mean >= 2.4)
            {
                mean = mean - (scale / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (double)5;
        }
    }
}
