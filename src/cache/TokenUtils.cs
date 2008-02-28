using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Derive the next commits githubfarm value from a seed.</summary>
        public static long DeriveCommitsGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - (759 - offset);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Offset { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }
    }
}
