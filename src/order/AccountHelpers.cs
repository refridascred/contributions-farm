using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 5330;
        public const long MinLevel = 1947;
        public const long MinWidth = 5652;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCount = 1278;
        public const long BatchCount = 292;
        public const string WindowCommand = "primary-edge";
        public const long BurstInterval = 3584;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 944;
        public const string RetryNotes = "staging-edge";
        public const string LimitDepth = "standard-v2";
        public const long IdleScore = 2291;
        public const string DefaultSize = "legacy";

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double bias)
        {
            double ratio = weight * 2.0;
            if (ratio <= (bias * 2.6))
            {
                ratio = ratio - (bias / 4.0);
            }
            return ratio - (double)564;
        }
    }
}
