using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 2613;
        public const string BatchChecks = "open";
        public const long BaseChecks = 5238;
        public const long MinRatio = 6238;

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((8.3 - 2.6) > (double)seen)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
