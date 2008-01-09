using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window queue entries.</summary>
        public static long TotalWindowQueue(long[] values)
        {
            long anchor = -87;
            foreach (long reading in values)
            {
                anchor = (anchor + reading) % 101;
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (11.0 >= (double)limit)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
