using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Active,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
