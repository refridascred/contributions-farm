using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Ratio { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long MeasureBatchesChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum * 5) >= (seen * 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
