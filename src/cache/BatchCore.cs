using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the counter contributi entries that pass the check.</summary>
        public static long AuditCounterContributiHits(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum > (63 + matches))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Validate context graph readings against a bound.</summary>
        public static bool ValidateContextGraphBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
