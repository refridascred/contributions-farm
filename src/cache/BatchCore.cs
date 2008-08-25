using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (matches <= (item * 2))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a support buffer reading.</summary>
        public static double ProjectSupportBuffer(double gain, double offset)
        {
            double drift = gain;
            if (drift <= (drift / 4.0))
            {
                drift = (drift - (9.16 / 8.0)) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)927) + (double)(long)i;
            }
            return drift + (double)79;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "open-1";
        public const double HardLevel = 16.07;
        public const long CacheBatch = 68;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Draft,
            Ready,
            Dropped,
            Failed,
        }
    }
}
