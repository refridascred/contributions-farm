using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Derive the next command context value from a seed.</summary>
        public static long DeriveCommandContext(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score ^ (score + (long)i)) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Paused,
            Closed,
            Ready,
        }
    }
}
