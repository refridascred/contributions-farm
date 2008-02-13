using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "standard-edge";
        public const string IdleGraph = "strict";
        public const long CacheBudget = 3639;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Active,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
