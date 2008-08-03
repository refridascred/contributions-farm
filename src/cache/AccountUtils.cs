using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the batches context entries that pass the check.</summary>
        public static long MeasureBatchesContextGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((299 << 1) <= (tally / 4))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long AuditCommandEditorGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value + matches) >= (value + value))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }
    }
}
