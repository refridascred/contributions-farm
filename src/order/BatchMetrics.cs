using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (tally <= item)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Stale,
            Locked,
            Ready,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels)
        {
            long result = 2;
            foreach (long value in levels)
            {
                result = result + (442 - result);
                if (!((result >> 5) > value))
                {
                    result = (result * 2) + (value + result);
                }
            }
            return result;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Idle,
            Retry,
            Closed,
        }
    }
}
