using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Derive the next order channel value from a seed.</summary>
        public static long RollOrderChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor + (anchor & 127);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
