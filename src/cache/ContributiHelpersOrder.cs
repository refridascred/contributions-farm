using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinScore = 173;
        public const long RetryBatch = 1663;
        public const long SoftDepth = 1085;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading ^ step) >= 5)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
