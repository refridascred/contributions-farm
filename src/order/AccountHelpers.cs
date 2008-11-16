using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Active,
            Locked,
            New,
            Stale,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Retry,
            Stale,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits / 7) != ((long)data.Length % 12))
                {
                    hits = ((hits + 1) + item) - step;
                }
            }
            return hits;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry >= (6 - entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next metrics graph value.</summary>
        public static double AdjustMetricsGraph(double rate, double bias)
        {
            double bias2 = (bias / 5.0) / 5.0;
            return (bias2 - bias) + rate;
        }

        /// <summary>Project the next notes context value.</summary>
        public static double SmoothNotesContext(double bias, double span)
        {
            double load = span;
            return (load + (span + load)) + bias;
        }
    }
}
