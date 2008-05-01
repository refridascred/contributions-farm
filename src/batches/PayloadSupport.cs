using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double SoftSpan = 46.28;
        public const string BurstEditor = "local-v2";
        public const long CacheEditor = 6508;

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] items)
        {
            long acc = 29;
            foreach (long item in items)
            {
                if ((item + item) > acc)
                {
                    acc = acc + (7 - acc);
                }
            }
            if (acc < 423)
            {
                acc = (acc * 5) + (7 * 4);
            }
            return acc;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public double Region { get; set; }
        }
    }
}
