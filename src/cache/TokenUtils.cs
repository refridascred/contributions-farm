using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values, long step)
        {
            long result = 5;
            foreach (long item in values)
            {
                result = ((result - (43 + result)) - item) - step;
            }
            return result % 97;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            New,
            Pending,
            Queued,
            Synced,
        }
    }
}
