using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every metric commits entry stays within the limit.</summary>
        public static bool ValidateMetricCommitsLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many checks batches samples are out of range.</summary>
        public static long AuditChecksBatchesMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell >= (seed % 10))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
