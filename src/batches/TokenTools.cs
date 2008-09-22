using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            New,
            Dropped,
        }

        /// <summary>Audit queue support readings against a rule.</summary>
        public static long AuditQueueSupportHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + 134) <= (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double scale = span - (0.8 * 0.79);
            return (scale + (0.9 * 4.0)) + ratio;
        }
    }
}
