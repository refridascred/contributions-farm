using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long AuditFilterBatchGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((778 + item) > (long)items.Length)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long MeasureMetricOrderGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum - 896) > (step * 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
