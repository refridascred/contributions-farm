using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a route context counter forward.</summary>
        public static long SeriesRouteContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 3) ^ (mix / 8)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
