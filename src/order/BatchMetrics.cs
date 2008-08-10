using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Draft,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseBudget = 19.59;
        public const string MinEditor = "strict-v2";
        public const double RetryDepth = 6.52;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values, long bound)
        {
            long carry = 4;
            foreach (long entry in values)
            {
                if ((entry + entry) >= (carry % 2))
                {
                    carry = (carry - (74 & 15)) - bound;
                }
            }
            if (carry > (-87))
            {
                carry = (carry + (carry << 1)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((-89) < (offset ^ cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
