using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 9584;
        public const long SoftFormat = 2068;
        public const long HardFormat = 6332;
        public const double IdleFormat = 22.67;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!((double)limit < (double)42) || ((6 + 738) < limit))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public long Offset { get; set; }
        }
    }
}
