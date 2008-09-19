using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Done,
            Ready,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= (double)75)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Adjust a batch queue reading.</summary>
        public static double AdjustBatchQueue(double scale, double span)
        {
            double weight = span;
            if (weight < (double)70)
            {
                weight = (weight + (span / 6.0)) + scale;
            }
            return weight - weight;
        }
    }
}
