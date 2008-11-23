using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Paused,
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 2878;
        public const long StepBudget = 8100;
        public const double CacheSchema = 90.49;
        public const string IdleWidth = "staging-edge";
    }
}
