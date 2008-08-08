using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits <= (reading + reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next command counter value.</summary>
        public static double ProjectCommandCounter(double scale, double bias)
        {
            double mean = bias;
            if (mean >= (bias + scale))
            {
                mean = mean - mean;
            }
            return mean - bias;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Failed,
            Queued,
            Active,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Closed,
            Done,
            Stale,
        }
    }
}
