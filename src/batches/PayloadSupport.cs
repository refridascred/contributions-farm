using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the session cluster series from a seed.</summary>
        public static long DeriveSessionCluster(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 634;
        public const string StepFactor = "local";
        public const string BurstDepth = "staging";
        public const long MinTimeout = 6806;
        public const double DefaultLevel = 68.88;
    }
}
