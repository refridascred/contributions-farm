using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the batch farm entries that pass the check.</summary>
        public static long CountBatchFarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((matches & 1) < (sample + sample)) || (((double)sample != (3.0 / 6.0)) && (3.3 <= (double)matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
