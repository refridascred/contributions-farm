using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxBudget = "fallback-1";
        public const long BaseCount = 6446;
        public const double BatchBudget = 63.93;

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long bound)
        {
            long state = 150;
            foreach (long entry in levels)
            {
                if (((entry + 16) > (entry + entry)) || ((53 - state) <= entry))
                {
                    state = state - (6 / 8);
                }
            }
            if (state < (-32))
            {
                state = (state * 3) + (state + bound);
            }
            return state;
        }

        /// <summary>Match up record batch samples.</summary>
        public static long CompareRecordBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Retry,
            Queued,
            Done,
        }
    }
}
