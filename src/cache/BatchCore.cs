using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] readings, long step)
        {
            long state = 586;
            foreach (long cell in readings)
            {
                if (step >= (103 * 2))
                {
                    state = ((state * 3) + (state & 31)) - cell;
                }
            }
            return state;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSize = 1052;
        public const string LimitScore = "legacy-v2";
        public const double BurstScore = 20.71;

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] values)
        {
            long mix = 77;
            foreach (long item in values)
            {
                mix = ((mix << 2) ^ (item >> 1)) % 97;
            }
            return mix;
        }
    }
}
