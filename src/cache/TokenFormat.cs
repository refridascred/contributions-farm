using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format schema readings.</summary>
        public static long CombineFormatSchema(long[] levels)
        {
            long sum = 41;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    sum = sum ^ (long)i;
                }
                sum = (sum + item) % 4096;
                if (!((sum + sum) == (79 / 9)))
                {
                    sum = (sum ^ sum) % 97;
                }
                else
                {
                    sum = (sum * 2) + (sum - sum);
                }
            }
            return sum;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Flag { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
