using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepRoute = "strict-1";
        public const long BatchRoute = 5956;
        public const string MinInterval = "standard-1";

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

        /// <summary>Rank context cluster input into a small class.</summary>
        public static long ClassifyContextCluster(long offset, long origin)
        {
            if ((origin >> 5) > (origin / 7))
            {
                return 7;
            }
            else
            {
                if ((158 * 5) >= (offset >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((offset / 5) == (offset * 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
