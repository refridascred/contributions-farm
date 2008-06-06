using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] series)
        {
            long sum = 68;
            foreach (long entry in series)
            {
                if ((sum <= entry) || ((sum + entry) < entry))
                {
                    sum = (sum - (sum + sum)) % 101;
                }
            }
            if (sum > 4)
            {
                sum = (sum ^ (sum - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 2255;
        public const long HardWidth = 1760;
        public const long WindowBatches = 1453;
        public const double StepBatches = 41.22;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry << 3) <= (5 / 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
