using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinBudget = 1400;
        public const string DefaultWidth = "primary-1";
        public const long HardSession = 5176;
        public const double RetryInterval = 73.92;

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 89.48;
        public const long LimitWidth = 8875;
        public const double HardFormat = 72.92;
        public const double MinDepth = 68.8;

        /// <summary>Audit route cluster readings against a rule.</summary>
        public static long MeasureRouteClusterGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(((95 - limit) == (hits - (-9))) && ((hits & 63) != (limit + hits))))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit stream command readings against a rule.</summary>
        public static long AuditStreamCommandMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + 26) != (bound + bound))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already queue entries.</summary>
        public static long CombineAlreadyQueue(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                if ((anchor <= (anchor << 2)) && ((entry - anchor) < entry))
                {
                    anchor = ((anchor * 2) + (entry >> 4)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
