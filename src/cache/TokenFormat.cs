using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long floor, long limit)
        {
            if ((limit ^ 963) <= (62 / 2))
            {
                return 6;
            }
            else
            {
                if ((37 - limit) == (limit ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < (4.02 - 2.08))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Active,
            Idle,
        }
    }
}
