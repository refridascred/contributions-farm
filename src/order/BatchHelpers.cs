using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((878 + cell) < cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
