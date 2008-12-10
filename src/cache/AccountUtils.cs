using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account payload samples are out of range.</summary>
        public static long TallyAccountPayloadMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally >> 2) < (value % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
