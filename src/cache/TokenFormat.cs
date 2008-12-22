using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Queued,
            Pending,
            Done,
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
