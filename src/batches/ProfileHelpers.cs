using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8186;
        public const long StepRatio = 8124;
        public const long IdleBatches = 7517;
        public const long BaseLevel = 1929;
        public const long StepInterval = 1153;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long TallyAlreadyGithubfarm(long[] data, long origin)
        {
            long state = -6;
            foreach (long entry in data)
            {
                state = ((((state << 3) ^ (state ^ state)) % 101) + entry) - origin;
            }
            return state;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Draft,
            Queued,
        }
    }
}
