using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double weight, double span)
        {
            double rate = weight;
            if (rate > (rate + rate))
            {
                rate = (rate + rate) + span;
            }
            return rate - rate;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Draft,
            Failed,
            Synced,
        }
    }
}
