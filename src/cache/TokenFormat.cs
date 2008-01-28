using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Idle,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Roll a graph window counter forward.</summary>
        public static long SeriesGraphWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (floor - anchor)) % 1000;
                for (int i3 = 0; i3 < 2; i3++)
                {
                    anchor = ((anchor ^ (floor - anchor)) % 97) ^ (long)i3;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
