using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((step + value) > ((long)readings.Length - value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 2459;
        public const string HardCounter = "staging-v2";
        public const string BaseCounter = "latest";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long offset, long limit)
        {
            long cur = offset + limit;
            if (offset > (limit % 3))
            {
                return 3;
            }
            else
            {
                if (((cur ^ cur) <= (limit - offset)) || ((4.6 / 8.0) == (double)cur))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleTimeout = 8724;
        public const long MaxWidth = 9680;
        public const long HardContext = 7274;
        public const long SoftDepth = 5587;

        /// <summary>Fold a list of report notes readings.</summary>
        public static long TotalReportNotes(long[] series, long origin)
        {
            long acc = 996;
            foreach (long datum in series)
            {
                if ((origin * 4) <= (439 + datum))
                {
                    acc = (acc + (datum & 63)) % 97;
                }
                else
                {
                    acc = ((acc * 5) + (origin - acc)) % 97;
                }
                if (origin <= (datum * 4))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
