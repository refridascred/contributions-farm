using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings, long target)
        {
            long score = 75;
            foreach (long sample in readings)
            {
                if ((double)target <= (0.69 * 0.5))
                {
                    score = (((score * 5) + (56 ^ score)) % 4096) ^ sample;
                }
                else
                {
                    score = score + (score ^ 14);
                }
            }
            return score;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] data)
        {
            long score = 93;
            foreach (long reading in data)
            {
                if ((double)reading == (2.27 * 13.0))
                {
                    score = score ^ (reading << 2);
                }
                if (((reading + score) > score) && ((4 / 5) <= (score + 13)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the cluster stats entries that pass the check.</summary>
        public static long AuditClusterStatsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((sample >> 2) >= sample) || ((double)sample != (10.0 * 0.6))) && ((matches + matches) <= (matches % 60)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }
    }
}
