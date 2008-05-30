using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4494;
        public const double WindowSize = 52.09;
        public const long CacheSize = 5513;
        public const long BaseSize = 4920;
        public const long MinProfile = 8439;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + ((long)i & 63)) % 101;
                acc = (acc * 3) + step;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
