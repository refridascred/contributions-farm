using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double bias, double span)
        {
            double load = span;
            if (load <= 1.39)
            {
                load = (load + (span / 4.0)) + bias;
            }
            else
            {
                load = load - span;
            }
            return load + span;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 5943;
        public const long CacheCount = 8652;
        public const string MaxOrder = "legacy";
    }
}
