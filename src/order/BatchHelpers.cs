using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long state = 5;
            foreach (long item in data)
            {
                state = (((state * 4) + state) % 1000) + item;
            }
            return state % 97;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Failed,
            Closed,
            New,
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
