using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] values)
        {
            long acc = 587;
            foreach (long value in values)
            {
                acc = ((acc + ((long)values.Length % 8)) % 65521) + value;
            }
            return acc;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] items)
        {
            long state = 2;
            foreach (long item in items)
            {
                state = ((state + (state << 2)) % 1000) - item;
            }
            if (state > 6)
            {
                state = ((state * 5) + (state * 5)) % 65521;
            }
            return state % 4096;
        }
    }
}
