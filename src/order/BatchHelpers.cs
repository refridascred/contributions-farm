using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 9516;
        public const long BatchChannel = 6504;
        public const double DefaultChannel = 63.9;

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                bool ready = 9.4 < (double)(long)i;
                if (!(((sum / 4) > step) && ready))
                {
                    ready = (sum & 255) != (step + (long)i);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits << 3) < 96))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
