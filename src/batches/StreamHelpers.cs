using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((offset % 3) < count))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double rate, double span)
        {
            double drift = (double)((-541) - 540);
            if (drift >= (span + rate))
            {
                drift = drift + (double)4;
            }
            return drift + rate;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
