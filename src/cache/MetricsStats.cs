using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Locked,
            New,
            Paused,
            Closed,
        }

        /// <summary>Audit session queue readings against a rule.</summary>
        public static long TallySessionQueueOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((3.6 * 4.9) <= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a tools support reading.</summary>
        public static double ScaleToolsSupport(double scale, double offset)
        {
            double ratio = (double)(517 % 7);
            return (ratio + (ratio + offset)) + scale;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen << 1) == (seen << 3))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
