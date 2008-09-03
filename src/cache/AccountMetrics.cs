using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the tools token entries that pass the check.</summary>
        public static long MeasureToolsTokenOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((matches << 1) > (datum + (long)series.Length)) || (datum >= (533 ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] samples)
        {
            long acc = 505;
            foreach (long entry in samples)
            {
                acc = ((acc << 2) ^ acc) % 255;
                if ((entry + acc) >= (entry * 4))
                {
                    break;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc << 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
