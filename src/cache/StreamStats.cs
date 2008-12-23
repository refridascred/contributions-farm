using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            New,
            Done,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Token { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 459;
        public const long IdleLayout = 8884;
        public const long LimitLayout = 8072;
        public const string BurstDepth = "latest-v2";
        public const long WindowLayout = 9793;
    }
}
