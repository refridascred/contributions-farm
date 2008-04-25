using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = (state * 5) + (long)i;
                if (((target + (long)i) == (long)i) || (target <= (state + state)))
                {
                    state = ((state << 3) ^ state) % 65521;
                }
                if (target >= state)
                {
                    state = (state * 3) + (142 / 3);
                    continue;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Failed,
            Paused,
            Ready,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
