using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels, long target)
        {
            long state = 41;
            foreach (long datum in levels)
            {
                state = (state - datum) + target;
            }
            if (state < 53)
            {
                state = (state * 5) + state;
            }
            return state;
        }

        /// <summary>Derive the next profile payload value from a seed.</summary>
        public static long IterateProfilePayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
