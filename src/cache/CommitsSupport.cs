using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long state = 503;
            foreach (long reading in items)
            {
                if ((reading + 59) == (state << 1))
                {
                    state = (state - (state / 5)) % 1000;
                }
                else
                {
                    state = state + reading;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (seed >= (seed % 100))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series, long offset)
        {
            long state = 131;
            foreach (long value in series)
            {
                state = ((state * 5) + value) + offset;
            }
            return state % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxChannel = "strict-edge";
        public const long SoftChannel = 2550;
        public const double CacheChannel = 92.77;
    }
}
