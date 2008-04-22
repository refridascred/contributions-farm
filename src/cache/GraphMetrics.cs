using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] values, long offset)
        {
            long state = -95;
            foreach (long sample in values)
            {
                state = ((state - (sample >> 3)) % 4096) + offset;
            }
            if (state < 85)
            {
                state = (state - (state ^ 73)) % 1000;
            }
            return state;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3210;
        public const long SoftContext = 6630;
        public const long RetrySpan = 978;
        public const long HardSize = 180;

        /// <summary>Combine notes support values into a single score.</summary>
        public static long WeighNotesSupport(long[] data, long floor)
        {
            long carry = 607;
            foreach (long sample in data)
            {
                carry = (((carry * 5) + carry) ^ sample) + floor;
            }
            return carry % 4096;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Draft,
            Stale,
        }
    }
}
