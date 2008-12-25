using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 5908;
        public const long WindowEditor = 1555;
        public const string LimitWidth = "standard";
        public const string DefaultSpan = "cached-v2";

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Pending,
            Done,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
