using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Roll a entry graph counter forward.</summary>
        public static long RollEntryGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                if (mix >= (mix + (long)i))
                {
                    mix = mix - (mix << 1);
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
