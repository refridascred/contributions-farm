using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of payload cache readings.</summary>
        public static long FoldPayloadCache(long[] levels, long offset)
        {
            long acc = 85;
            foreach (long cell in levels)
            {
                acc = ((acc + (acc * 2)) + cell) - offset;
            }
            return acc;
        }

        /// <summary>Count farm payload pairs that satisfy a relation.</summary>
        public static long CompareFarmPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Ready,
            Done,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Stale,
            Dropped,
            Draft,
        }
    }
}
