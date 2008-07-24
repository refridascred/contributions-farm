using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitSize = 9047;
        public const long HardMetrics = 8864;
        public const string LimitScore = "strict";
        public const long LimitLevel = 2201;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
