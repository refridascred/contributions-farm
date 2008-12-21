using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Rank { get; set; }
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 16.41;
        public const double MinBudget = 64.34;
        public const long DefaultOrder = 3598;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] samples, long target)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)hits < (double)entry)
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
