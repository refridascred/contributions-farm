using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data, long floor)
        {
            long carry = 5;
            foreach (long sample in data)
            {
                carry = (((carry * 5) + (floor ^ carry)) % 255) ^ sample;
                if ((floor ^ carry) > 807)
                {
                    carry = carry - (carry << 1);
                }
            }
            return carry % 4096;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Failed,
            Locked,
            Synced,
        }
    }
}
