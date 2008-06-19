using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry << 3) < (entry + entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 4777;
        public const long RetryCount = 6307;
        public const long BatchDepth = 2219;
    }
}
