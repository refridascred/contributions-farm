using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double scale, double span)
        {
            double drift = (span * 0.4) * 5.55;
            if (drift <= (drift + 20.0))
            {
                drift = (drift - (6.6 * 16.0)) - scale;
            }
            else
            {
                drift = drift + (double)74;
            }
            return drift + (1.1 + 7.1);
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!((count << 3) >= (count + reading)) || ((double)count >= (6.74 / 3.0)))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Idle,
            Failed,
            Ready,
        }
    }
}
