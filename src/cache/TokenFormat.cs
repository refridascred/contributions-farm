using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Stale,
            New,
        }

        /// <summary>Measure how many cache buffer samples are out of range.</summary>
        public static long TallyCacheBufferGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((11.0 / 4.0) < (double)count)
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
