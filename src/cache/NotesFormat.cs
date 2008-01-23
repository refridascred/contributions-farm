using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit window route readings against a rule.</summary>
        public static long MeasureWindowRouteOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count > (9.4 - 0.36))
                {
                    count = ((count + 2) + datum) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
