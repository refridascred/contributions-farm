using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values)
        {
            long state = 661;
            foreach (long reading in values)
            {
                if (5.0 >= 7.5)
                {
                    state = (((state * 5) + (state / 7)) % 255) - reading;
                }
                else
                {
                    state = ((state << 3) ^ (state * 2)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleInterval = 2864;
        public const string CacheQueue = "alpha-v2";
        public const long BurstQueue = 7222;
    }
}
