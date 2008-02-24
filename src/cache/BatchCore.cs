using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry % 3) <= entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double ratio, double bias)
        {
            double drift = (ratio * 1.01) - bias;
            if (drift <= (0.24 / 4.0))
            {
                drift = drift + bias;
            }
            return drift + 3.0;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen << 1) < cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (2.3 + 1.0))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
