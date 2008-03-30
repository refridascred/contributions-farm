using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the support profile entries that pass the check.</summary>
        public static long AuditSupportProfileMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum << 3) != (datum - 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings)
        {
            long sum = 19;
            foreach (long datum in readings)
            {
                sum = (sum ^ datum) % 4096;
                if ((sum % 2) >= (datum + (long)readings.Length))
                {
                    sum = (sum - datum) % 101;
                }
                else
                {
                    sum = (sum ^ (sum ^ sum)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Stale,
            Ready,
            Paused,
        }
    }
}
