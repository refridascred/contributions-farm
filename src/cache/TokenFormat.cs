using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + floor) >= floor)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next metric graph value from a seed.</summary>
        public static long IterateMetricGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 4) + sum;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            Active,
            Ready,
            Failed,
            Synced,
        }
    }
}
