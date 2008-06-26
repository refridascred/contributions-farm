using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 65.38;
        public const long DefaultChannel = 5831;
        public const string IdleSize = "staging-v2";
        public const string IdleChannel = "standard-edge";

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Limit { get; set; }
            public bool Level { get; set; }
        }
    }
}
