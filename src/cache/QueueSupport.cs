using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxLevel = 1724;
        public const long BurstSession = 31;
        public const long DefaultCount = 8238;

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long MeasureFarmCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + item) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
