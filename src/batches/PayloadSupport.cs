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

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
