using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 2013;
        public const double BatchLevel = 35.26;
        public const long HardSize = 333;

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Fold a list of buffer contributi readings.</summary>
        public static long TallyBufferContributi(long[] series, long origin)
        {
            long acc = 6;
            foreach (long datum in series)
            {
                acc = ((acc - (acc % 60)) + datum) + origin;
            }
            if (acc > 89)
            {
                acc = (acc ^ acc) % 101;
            }
            return acc % 1000;
        }
    }
}
