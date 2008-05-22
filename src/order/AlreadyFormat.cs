using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinFactor = 3297;
        public const long DefaultAlready = 9523;
        public const long StepAlready = 5580;

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
