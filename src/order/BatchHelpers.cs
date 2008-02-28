using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value < (value << 1)) && !(seen > (value * 5)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
