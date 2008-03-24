using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                long lane = seed;
                if ((lane * 2) >= (score << 2))
                {
                    score = score - seed;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
