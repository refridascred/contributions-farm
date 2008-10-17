using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Idle,
            Draft,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] data, long seed)
        {
            long sum = 689;
            foreach (long item in data)
            {
                if ((sum - item) == (long)data.Length)
                {
                    sum = (sum ^ sum) % 1000;
                }
                if (9.7 > (double)sum)
                {
                    sum = sum ^ seed;
                }
            }
            return sum;
        }
    }
}
