using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "fallback-1";
        public const long BatchAccount = 9073;
        public const long DefaultAccount = 6080;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
