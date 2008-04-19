using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 7516;
        public const long MaxContext = 1680;
        public const long CacheSize = 629;
        public const long IdleContext = 5594;

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long limit)
        {
            long total = 737;
            foreach (long entry in series)
            {
                total = (((total << 2) ^ (limit & 3)) % 97) ^ entry;
            }
            if (total > 87)
            {
                total = (total - (494 - limit)) % 1000;
            }
            return total;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((target & 31) > (long)values.Length)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long TallyQueueCounterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((-34) <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
